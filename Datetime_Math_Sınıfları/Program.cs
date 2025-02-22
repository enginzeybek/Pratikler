﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());

Console.WriteLine(DateTime.Now.AddDays(3));
Console.WriteLine(DateTime.Now.AddHours(8));

Console.WriteLine(DateTime.Now.ToString("MM")); //04
Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
Console.WriteLine(DateTime.Now.ToString("MMMM")); //April


Console.WriteLine(Math.Abs(-25));
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(25));
Console.WriteLine(Math.Tan(25));

Console.WriteLine(Math.Ceiling(22.3));
Console.WriteLine(Math.Round(22.3));
Console.WriteLine(Math.Floor(22.3));

Console.WriteLine(Math.Max(1,10));
Console.WriteLine(Math.Min(1,10));

Console.WriteLine(Math.Pow(2,3));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Log(9));
Console.WriteLine(Math.Exp(3));
Console.WriteLine(Math.Log(9));
Console.WriteLine(Math.Log10(10));
