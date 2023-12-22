using System;
public class MyDate
{
    protected short Year;
    protected byte Month;
    protected byte Day;
    protected byte Hours;
    protected byte Minutes;

    public MyDate()
    {
        Year = 2000;
        Month = 12;
        Day = 30;
        Hours = 24;
        Minutes = 59;
    }
    public MyDate(short year, byte month, byte day, byte hours, byte minutes)
    {
        Year = year;
        Month = month;
        Day = day;
        Hours = hours;
        Minutes = minutes;
    }
    public MyDate(short year, byte month, byte day)
    {
        Year = year;
        Month = month;
        Day = day;
    }
    public MyDate(byte hours, byte minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
    public MyDate(MyDate myDate)
    {
        Year = myDate.Year;
        Month = myDate.Month;
        Day = myDate.Day;
        Hours = myDate.Hours;
        Minutes = myDate.Minutes;
    }
    public void SetMyDateYear(short value)
    {
        if (value > 0) Year = value;
        else throw new Exception("Year can not be negative");
    }
    public void SetMyDateMonth(byte value)
    {
        if (value > 0 && value < 13) Month = value;
        else throw new Exception("Month can not be less than 1 and more than 12");
    }
    public void SetMyDateDay(byte value)
    {
        if (value > 0 && value < 32) Day = value;
        else throw new Exception("Day can not be less than 1 and more than 31");
    }
    public void SetMyDateHours(byte value)
    {
        if (value >= 0 && value < 24) Hours = value;
        else throw new Exception("Hours can not be less than 0 and more than 23");
    }
    public void SetMyDateMinutes(byte value)
    {
        if (value >= 0 && value < 60) Minutes = value;
        else throw new Exception("Minutes can not be less than 0 and more than 59");
    }
    public short GetMyDateYear()  
    { 
        return Year;
    }
    public byte GetMyDateMonth() 
    { 
        return Month;
    }
    public byte GetMyDateDay() 
    {  
        return Day;
    }
    public byte GetMyDateHours() 
    { 
        return Hours;
    }
    public byte GetMyDateMinutes() 
    { 
        return Minutes;
    }
}