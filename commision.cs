using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get product price input
Console.Write("Product Price: ");
double Product = Console.ReadLine();

// commisions input
Console.Write("Merchant Commission (percent): "); // merchant commission
int Merchant = Console.ReadLine();
Console.Write("Distributor Commission (percent)"); // distributor commission
int Distributor = Console.ReadLine();

// conversions and output
Console.WriteLine("Merchant Earnings: " + (Product * (Merchant / 100)));
Console.WriteLine("Distributor Earnings: " + (Product * (Distributor / 100)));
Console.WriteLine("Producer Earnings: " + (Product * ((100 - (Merchant + Distributor)) / 100)));