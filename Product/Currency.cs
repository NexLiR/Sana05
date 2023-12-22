using System;
public class Currency
{
    protected string Name;
    protected double ExRate;

    public Currency()
    {
        Name = "Unknown";
        ExRate = 0;
    }
    public Currency(string name, double exRate)
    {
        Name = name;
        ExRate = exRate;
    }
    public Currency(string name)
    {
        Name = name;
    }
    public Currency(double exRate)
    {
        ExRate = exRate;
    }
    public Currency(Currency currency)
    {
        Name = currency.Name;
        ExRate = currency.ExRate;
    }
    public string GetName()
    {
        return Name;
    }
    public double GetExRate()
    {
        return ExRate;
    }
    public void SetName(string name)
    {
        if (name.Length > 0) Name = name;
        else throw new Exception("Name can not be empty");
    }
    public void SetExRate(double exRate)
    {
        if (exRate > 0) ExRate = exRate;
        else throw new Exception("Exchange rate can not be negative");
    }
}
