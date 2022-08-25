// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(DateTime.Now);// günün tarihini getiri.
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.DayOfYear);
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(301));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(18));
Console.WriteLine(DateTime.Now.AddMilliseconds(58));

// Datetime Format
Console.WriteLine(DateTime.Now.ToString("d"));
Console.WriteLine(DateTime.Now.ToString("ddd"));
Console.WriteLine(DateTime.Now.ToString("dddd"));// Saturday
                                                   // 24
                                                    // Sat
Console.WriteLine(DateTime.Now.ToString("MM"));// 04
Console.WriteLine(DateTime.Now.ToString("MMM"));// Apr
Console.WriteLine(DateTime.Now.ToString("MMMM"));// prit
                                                       
Console.WriteLine(DateTime.Now.ToString("yy"));//2
Console.WriteLine(DateTime.Now.ToString("yyyy"));// 2021


// Math Kutiphanesi
Console.WriteLine(Math.Abs(-25));// 251
Console.WriteLine(Math.Sin(18));
Console.WriteLine(Math.Cos(1));
Console.WriteLine(Math.Tan(10));
Console.WriteLine(Math.Ceiling(22.33));// 23
Console.WriteLine(Math.Round (22.3));// 22
Console.WriteLine(Math.Round (22.7));// 23
Console.WriteLine(Math.Floor(22.7));// 22
Console.WriteLine(Math.Max(2,6)); 
Console.WriteLine(Math.Min(2,3));
Console.WriteLine(Math.Pow(3,4));
Console.WriteLine(Math.Sqrt(9)); // karekök alir.3
Console.WriteLine(Math.Log(91));
Console.WriteLine(Math.Exp(31));
Console.WriteLine(Math.Log10(10));
 
  