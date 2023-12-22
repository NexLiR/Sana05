using System;
public class Product
{
    protected string Name;
    protected float Price;
    protected Currency Cost;
    protected int Quantity;
    protected string Producer;
    protected float Weight;

    public Product()
    {
        Name = "Unknown";
        Price = 0;
        Cost = new Currency();
        Quantity = 0;
        Producer = "Unknown";
        Weight = 0;
    }
    public Product(string name, float price, Currency cost, int quantity, string producer, float weight)
    {
        Name = name;
        Price = price;
        Cost = cost;
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }
    public Product(string name, float price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    public Product(string producer, float weight)
    {
        Producer = producer;
        Weight = weight;
    }
    public Product(Product product)
    {
        Name = product.Name;
        Price = product.Price;
        Cost = product.Cost;
        Quantity = product.Quantity;
        Producer = product.Producer;
        Weight = product.Weight;
    }
    public string GetName()
    {
        return Name;
    }
    public float GetPrice()
    {
        return Price;
    }
    public Currency GetCost()
    {
        return Cost;
    }
    public int GetQuantity()
    {
        return Quantity;
    }
    public string GetProducer()
    {
        return Producer;
    }
    public float GetWeight()
    {
        return Weight;
    }
    public void SetName(string name)
    {
        if (name.Length > 0) Name = name;
        else throw new Exception("Name can not be empty");
    }
    public void SetPrice(float price)
    {
        if (price > 0) Price = price;
        else throw new Exception("Price can not be negative");
    }
    public void SetCost(Currency cost)
    {
        Cost = cost;
    }
    public void SetQuantity(int quantity)
    {
        if (quantity >= 0) Quantity = quantity;
        else throw new Exception("Quantity can not be negative");
    }
    public void SetProducer(string producer)
    {
        if (producer.Length > 0) Producer = producer;
        else throw new Exception("Producer can not be empty");
    }
    public void SetWeight(float weight)
    {
        if (weight > 0) Weight = weight;
        else throw new Exception("Weight can not be negative");
    }

}
