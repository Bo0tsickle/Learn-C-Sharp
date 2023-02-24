using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter image name: ");
string imageName = Console.ReadLine();

// compare
// if the lowercase version of the image name does not end with ".png", append .png on to the end
if (!imageName.ToLower().EndsWith(".png")) {
    imageName += ".png";
}

// output
Console.WriteLine("We will use the image name: " + imageName);