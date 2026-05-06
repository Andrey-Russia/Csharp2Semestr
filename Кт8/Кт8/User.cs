class User
{
    public string name { get; set; }
    public string email { get; set; }
    public string contractNumber { get; set; }
    public string tariff { get; set; }
}

class Contract
{
    public string contractNumber { get; set; }
    public string serviceAddress { get; set; }
    public DateTime expirationDate { get; set; }
}

class Result
{
    public string Name { get; set; }
    public int DaysLeft { get; set; }
}
