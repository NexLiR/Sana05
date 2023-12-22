using System;
internal class Program
{
    static void Main()
    {
        Product product = new Product();
        Console.WriteLine("Name: {0}", product.GetName());
        Console.WriteLine("Price: {0:F2}", product.GetPrice());
        Console.WriteLine("Cost: {0}, {1:F2}", product.GetCost().GetName(), product.GetCost().GetExRate());
        Console.WriteLine("Quantity: {0}", product.GetQuantity());
        Console.WriteLine("Producer: {0}", product.GetProducer());
        Console.WriteLine("Weight: {0}g\n", product.GetWeight());

        Product product1 = new Product("Bread", 1.50f, new Currency("UAN", 37.48), 5, "Khlib Zhytomyra", 450.0f);
        Console.WriteLine("Name: {0}", product1.GetName());
        Console.WriteLine("Price: {0:F2}", product1.GetPrice());
        Console.WriteLine("Cost: {0}, {1:F2}", product1.GetCost().GetName(), product1.GetCost().GetExRate());
        Console.WriteLine("Quantity: {0}", product1.GetQuantity());
        Console.WriteLine("Producer: {0}", product1.GetProducer());
        Console.WriteLine("Weight: {0}g", product1.GetWeight());
        double priceInUAH = product1.GetPrice() * product1.GetCost().GetExRate();
        Console.WriteLine("Price in UAH: {0:F2}", priceInUAH);
        double totalPriceInUAH = product1.GetTotalPriceInUAN();
        Console.WriteLine("Total price in UAH: {0:F2}", totalPriceInUAH);
        double totalWeight = product1.GetTotalWeight();
        Console.WriteLine("Total weight: {0}g\n", totalWeight);

        Product product2 = new Product();
        Console.Write("Enter product name: ");
        product2.SetName(Console.ReadLine());
        Console.Write("Enter product price: ");
        product2.SetPrice(float.Parse(Console.ReadLine()));
        Currency currency = new Currency();
        Console.Write("Enter currency name: ");
        currency.SetName(Console.ReadLine());
        Console.Write("Enter exchange rate: ");
        currency.SetExRate(double.Parse(Console.ReadLine()));
        product2.SetCost(currency);
        Console.Write("Enter product quantity: ");
        product2.SetQuantity(int.Parse(Console.ReadLine()));
        Console.Write("Enter product producer: ");
        product2.SetProducer(Console.ReadLine());
        Console.Write("Enter product weight: ");
        product2.SetWeight(float.Parse(Console.ReadLine()));
        Console.WriteLine("Name: {0}", product2.GetName());
        Console.WriteLine("Price: {0:F2}", product2.GetPrice());
        Console.WriteLine("Cost: {0}, {1:F2}", product2.GetCost().GetName(), product2.GetCost().GetExRate());
        Console.WriteLine("Quantity: {0}", product2.GetQuantity());
        Console.WriteLine("Producer: {0}", product2.GetProducer());
        Console.WriteLine("Weight: {0}g", product2.GetWeight());
        priceInUAH = product2.GetPrice() * product2.GetCost().GetExRate();
        Console.WriteLine("Price in UAH: {0:F2}", priceInUAH);
        totalPriceInUAH = product2.GetTotalPriceInUAN();
        Console.WriteLine("Total price in UAH: {0:F2}", totalPriceInUAH);
        totalWeight = product2.GetTotalWeight();
        Console.WriteLine("Total weight: {0}g", totalWeight);
    }
}