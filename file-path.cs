using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// finding path
string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

// Output
Console.WriteLine("Path to your desktop: " + pathToDesktop);

// waiting for enter
Console.ReadLine();