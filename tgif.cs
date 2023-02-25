using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get values
DateTime today = DateTime.Today;
DateTime friday = today;

// add days until next friday
while (friday != DayOfWeek.Friday) {
    friday = friday.AddDays(1);
}

// calc day difference
int dayDifference = friday - today;

// output
Console.WriteLine("Nearest Friday: " + friday.ToLongDateString);
Console.WriteLine("Remaining Days: " + dayDifference);