using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

DateTime now;
DateTime today;
now = DateTime.Now; // current date and time
today = DateTime.Today; // current date
DateTime tomorrow = today.AddDays(1);
Console.WriteLine("Now is " + now); // display current date and time
Console.WriteLine("Today is " + today); // display current date
Console.WriteLine("Today is " + today.ToLongDateString()); // display current date in long form
Console.WriteLine("I will start learning on " + tomorrow.ToShortDateString() + ".");
Console.ReadLine();