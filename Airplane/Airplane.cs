﻿using System;
public class Airplane
{
    protected string StartCity;
    protected string FinishCity;
    protected MyDate StartDate;
    protected MyDate FinishDate;
    
    public Airplane()
    {
        StartCity = "Kyiv";
        FinishCity = "Warsaw";
        StartDate = new MyDate();
        FinishDate = new MyDate();
    }
    public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = startDate;
        FinishDate = finishDate;
    }
    public Airplane(string startCity, string finishCity)
    {
        StartCity = startCity;
        FinishCity = finishCity;
    }
    public Airplane(MyDate startDate, MyDate finishDate)
    {
        StartDate = startDate;
        FinishDate = finishDate;
    }
    public Airplane(Airplane airplane)
    {
        StartCity = airplane.StartCity;
        FinishCity = airplane.FinishCity;
        StartDate = new MyDate(airplane.StartDate);
        FinishDate = new MyDate(airplane.FinishDate);
    }
    public void SetStartCity(string value)
    {
        StartCity = value;
    }
    public void SetFinishCity(string value)
    {
        FinishCity = value;
    }
    public void SetStartDate(MyDate value)
    {
        StartDate = value;
    }
    public void SetFinishDate(MyDate value)
    {
        FinishDate = value;
    }
    public string GetStartCity()
    {
        return StartCity;
    }
    public string GetFinishCity()
    {
        return FinishCity;
    }
    public MyDate GetStartDate()
    {
        return StartDate;
    }
    public MyDate GetFinishDate()
    {
        return FinishDate;
    }

    public int GetTotalTime(MyDate startDate, MyDate finishDate)
    {
        int totalTimeInMinutes = 0;
        DateTime date1 = new DateTime(startDate.GetMyDateYear(), startDate.GetMyDateMonth(), startDate.GetMyDateDay(), startDate.GetMyDateHours(), startDate.GetMyDateMinutes(), 0);
        DateTime date2 = new DateTime(finishDate.GetMyDateYear(), finishDate.GetMyDateMonth(), finishDate.GetMyDateDay(), finishDate.GetMyDateHours(), finishDate.GetMyDateMinutes(), 1);
        TimeSpan difference = date2 - date1;
        totalTimeInMinutes = (int)difference.TotalMinutes;
        return totalTimeInMinutes;
    }
    public bool IsArravingToday(MyDate startDate, MyDate finishDate)
    {
        bool isArravingToday = false;
        if (startDate.GetMyDateYear() == finishDate.GetMyDateYear() && startDate.GetMyDateMonth() == finishDate.GetMyDateMonth() && startDate.GetMyDateDay() == finishDate.GetMyDateDay())
        {
            isArravingToday = true;    
        }
        return isArravingToday;
    }
}