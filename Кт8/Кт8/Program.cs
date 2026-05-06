using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            if (!File.Exists("UserInfo.json") || !File.Exists("ContractsInfo.json"))
            {
                Console.WriteLine("Один из файлов не найден!");
                return;
            }

            string userJson = File.ReadAllText("UserInfo.json");
            string contractJson = File.ReadAllText("ContractsInfo.json");

            var users = JsonSerializer.Deserialize<List<User>>(userJson);
            var contracts = JsonSerializer.Deserialize<List<Contract>>(contractJson);

            if (users == null || contracts == null)
            {
                Console.WriteLine("Ошибка при чтении JSON!");
                return;
            }

            var vipUsers = users
                .Where(u => u.tariff == "VIP")
                .Join(contracts,
                    u => u.contractNumber,
                    c => c.contractNumber,
                    (u, c) => new Result
                    {
                        Name = u.name,
                        DaysLeft = Math.Max(0, (c.expirationDate - DateTime.Now).Days)
                    })
                .OrderByDescending(u => u.DaysLeft)
                .ToList();

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText("VIPUsers.json",
                JsonSerializer.Serialize(vipUsers, options));

            Console.WriteLine("Файл успешно создан!\n");

            Console.WriteLine("VIP пользователи:\n");
            Console.WriteLine($"{"Имя",-25} | {"Дней осталось",15}");
            Console.WriteLine(new string('-', 45));

            foreach (var user in vipUsers)
            {
                Console.WriteLine($"{user.Name,-25} | {user.DaysLeft,15}");
            }
        }
        catch (JsonException)
        {
            Console.WriteLine("Ошибка формата JSON!");
        }
        catch (IOException)
        {
            Console.WriteLine("Ошибка работы с файлами!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}