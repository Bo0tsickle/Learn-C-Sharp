using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Payment date: ");
DateTime paymentDate = Convert.ToDateTime(Console.ReadLine());
Console.Write("Invoice date: ");
DateTime invoiceDate = Convert.ToDateTime(Console.ReadLine());

// do checks to see if the invoice date is before the payment date
bool legality = true;
if (invoiceDate < paymentDate) {
    Console.WriteLine("Invoice cannot precede payment.");
    legality = false;
}
if (invoiceDate > paymentDate.AddDays(15)) {
    Console.WriteLine("Invoice cannot be over 15 days after payment.");
    legality = false;
}

// output
if (legality) {
    Console.WriteLine("Dates accepted.");
}