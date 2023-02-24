using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

try
{
    // get raw input 
    Console.Write("Date: ");
    string input = Console.ReadLine();
    
    // convert to DateTime
    DateTime enteredDate = Convert.ToDateTime(input);
    
    // conversions
    DateTime previousDate = enteredDate.AddDays(-1);
    DateTime followingDate = enteredDate.AddDays(1);
    
    // output
    Console.WriteLine("Previous day: " + previousDate.ToLongDateString());
    Console.WriteLine("Entered day: " + enteredDate.ToLongDateString());
    Console.WriteLine("Following day: " + followingDate.ToLongDateString());
}
catch (System.Exception)
{
    Console.WriteLine("Invalid date");
}