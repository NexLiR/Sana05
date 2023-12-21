using System;
internal class Program
{
    static void Main()
    {
        Airplane airplane = new Airplane();
        Console.WriteLine("Start city: {0}", airplane.GetStartCity());
        Console.WriteLine("Finish city: {0}", airplane.GetFinishCity());
        Console.WriteLine("Start date: {0}.{1:00}.{2} {3:00}:{4:00}", airplane.GetStartDate().GetMyDateDay(), airplane.GetStartDate().GetMyDateMonth(), airplane.GetStartDate().GetMyDateYear(), airplane.GetStartDate().GetMyDateHours(), airplane.GetStartDate().GetMyDateMinutes());
        Console.WriteLine("Finish date: {0}.{1:00}.{2} {3:00}:{4:00}", airplane.GetFinishDate().GetMyDateDay(), airplane.GetFinishDate().GetMyDateMonth(), airplane.GetFinishDate().GetMyDateYear(), airplane.GetFinishDate().GetMyDateHours(), airplane.GetFinishDate().GetMyDateMinutes());
        bool isArrivingToday = airplane.IsArravingToday(airplane.GetStartDate(), airplane.GetFinishDate());
        if (isArrivingToday == true) Console.WriteLine("The airplane arrives in the finish city on the same day as the flight starts\n");
        else Console.WriteLine("The airplane does not arrive in the finish city on the same day as the flight starts\n");
        Airplane airplane1 = new Airplane("Lviv", "Prague", new MyDate(2023, 12, 21, 21, 00), new MyDate(2023, 12, 22, 13, 30));
        Console.WriteLine("Start city: {0}", airplane1.GetStartCity());
        Console.WriteLine("Finish city: {0}", airplane1.GetFinishCity());
        Console.WriteLine("Start date: {0}.{1:00}.{2} {3:00}:{4:00}", airplane1.GetStartDate().GetMyDateDay(), airplane1.GetStartDate().GetMyDateMonth(), airplane1.GetStartDate().GetMyDateYear(), airplane1.GetStartDate().GetMyDateHours(), airplane1.GetStartDate().GetMyDateMinutes());
        Console.WriteLine("Finish date: {0}.{1:00}.{2} {3:00}:{4:00}", airplane1.GetFinishDate().GetMyDateDay(), airplane1.GetFinishDate().GetMyDateMonth(), airplane1.GetFinishDate().GetMyDateYear(), airplane1.GetFinishDate().GetMyDateHours(), airplane1.GetFinishDate().GetMyDateMinutes());
        Console.WriteLine("Total time of flying: {0}\n", airplane1.GetTotalTime(airplane1.GetStartDate(), airplane1.GetFinishDate()));
        
        Airplane airplane2 = new Airplane();
        Console.Write("Enter start city name: ");
        airplane2.SetStartCity(Console.ReadLine());
        Console.Write("Enter finish city name: ");
        airplane2.SetFinishCity(Console.ReadLine());
        Console.WriteLine("Enter start date:");
        MyDate startDate = new MyDate();
        Console.Write("Year: ");
        startDate.SetMyDateYear(short.Parse(Console.ReadLine()));
        Console.Write("Month: ");
        startDate.SetMyDateMonth(byte.Parse(Console.ReadLine()));
        Console.Write("Day: ");
        startDate.SetMyDateDay(byte.Parse(Console.ReadLine()));
        Console.Write("Hours: ");
        startDate.SetMyDateHours(byte.Parse(Console.ReadLine()));
        Console.Write("Minutes: ");
        startDate.SetMyDateMinutes(byte.Parse(Console.ReadLine()));
        airplane2.SetStartDate(startDate);
        Console.WriteLine("Enter finish date:");
        MyDate finishDate = new MyDate();
        Console.Write("Year: ");
        finishDate.SetMyDateYear(short.Parse(Console.ReadLine()));
        Console.Write("Month: ");
        finishDate.SetMyDateMonth(byte.Parse(Console.ReadLine()));
        Console.Write("Day: ");
        finishDate.SetMyDateDay(byte.Parse(Console.ReadLine()));
        Console.Write("Hours: ");
        finishDate.SetMyDateHours(byte.Parse(Console.ReadLine()));
        Console.Write("Minutes: ");
        finishDate.SetMyDateMinutes(byte.Parse(Console.ReadLine()));
        airplane2.SetFinishDate(finishDate);
        Console.WriteLine("\nStart city: {0}", airplane2.GetStartCity());
        Console.WriteLine("Finish city: {0}", airplane2.GetFinishCity());
        Console.WriteLine("Start date: {0}.{1:00}.{2} {3:00}:{4:00}", airplane2.GetStartDate().GetMyDateDay(), airplane2.GetStartDate().GetMyDateMonth(), airplane2.GetStartDate().GetMyDateYear(), airplane2.GetStartDate().GetMyDateHours(), airplane2.GetStartDate().GetMyDateMinutes());
        Console.WriteLine("Finish date: {0}.{1:00}.{2} {3:00}:{4:00}", airplane2.GetFinishDate().GetMyDateDay(), airplane2.GetFinishDate().GetMyDateMonth(), airplane2.GetFinishDate().GetMyDateYear(), airplane2.GetFinishDate().GetMyDateHours(), airplane2.GetFinishDate().GetMyDateMinutes());
        Console.WriteLine("Total time of flying: {0}", airplane2.GetTotalTime(airplane2.GetStartDate(), airplane2.GetFinishDate()));
        isArrivingToday = airplane2.IsArravingToday(airplane2.GetStartDate(), airplane2.GetFinishDate());
        if (isArrivingToday == true) Console.WriteLine("The airplane arrives in the finish city on the same day as the flight starts\n");
        else Console.WriteLine("The airplane does not arrive in the finish city on the same day as the flight starts\n");
    }
}