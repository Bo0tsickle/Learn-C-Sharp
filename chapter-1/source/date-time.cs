using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

DateTime now;
DateTime today;
now = DateTime.Now; // current date and time
today = DateTime.Today; // current date
DateTime tomorrow = today.AddDays(1); // tommorow's date
DateTime D_Day = new DateTime(1944, 6, 6); // the date of D-Day: 6/6/1944
Console.WriteLine("Now is " + now); // display current date and time
Console.WriteLine("Today is " + today); // display current date
Console.WriteLine("Today is " + today.ToLongDateString()); // display current date in long form
Console.WriteLine("I will start learning on " + tomorrow.ToShortDateString() + "."); // display tomorrow's date in short form
Console.WriteLine("The D-Day Operation was on " + D_Day.ToLongDateString());
Console.ReadLine();