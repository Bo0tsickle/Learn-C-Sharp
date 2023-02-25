using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Year of birth: ");
string input = Console.ReadLine();

// convert to int
int birth = Convert.ToInt32(input);

// get today's year
DateTime today = DateTime.Today;
int year = today.Year;

// get and give age
int age = year - birth;
Console.WriteLine("Today you are/will be: " + age);