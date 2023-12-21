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
        Year = value;
    }
    public void SetMyDateMonth(byte value)
    {
        Month = value;
    }
    public void SetMyDateDay(byte value)
    {
        Day = value;
    }
    public void SetMyDateHours(byte value)
    {
        Hours = value;
    }
    public void SetMyDateMinutes(byte value)
    {
        Minutes = value;
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