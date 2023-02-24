using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter customer price: ");
double vatCustomerPrice = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter VAT rate: ");
int vat = Convert.ToInt32(Console.ReadLine());

// conversions
double vatPercent = vat / 100.0;
double customerDivisor = 1 + vatPercent;
double originalCustomerPrice = vatCustomerPrice / customerDivisor;
double vatAmount = originalCustomerPrice * vatPercent;

// output
Console.WriteLine("Price without VAT: " + originalCustomerPrice);
Console.WriteLine("VAT: " + vatAmount);