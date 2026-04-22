using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5.Models
{
    public struct VisitorConfig
    {
        public string Name { get; }
        public int Age { get; }
        public string Section { get; }
        public decimal Price { get; }
        public decimal Payment { get; }

        public VisitorConfig(string name, int age, string section, decimal price, decimal payment)
        {
            Name = name;
            Age = age;
            Section = section;
            Price = price;
            Payment = payment;
        }
    }
}
