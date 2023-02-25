using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// set initial values
double height = 50.0;
double velocity = 8.0;
double acceleration = 0.0;
double fuel = 35.0;
double brakePercent = 0.0;
double brakeForce = 0.0;
bool malfunction = false;

// announcement
Console.WriteLine("- - - MOON LANDING - - -");
Console.WriteLine(" ");

// begin loop
while (height >= 0) {
    Console.WriteLine("Height: " + height.ToString("N1") + "  Velocity: " + velocity.ToString("N1") + "  Fuel: " + fuel.ToString("N1")); // step 1: announce variables
    Console.Write("Enter percentage of braking (0 to 100): "); // step 2: enter and recieve braking percentage
    brakePercent = (Convert.ToDouble(Console.ReadLine())) / 100; // and remember to convert it to a decimal
    try {
        if (brakePercent < 0 || brakePercent > 100) {
            malfunction = true;
        }
    }
    catch (Exception) {
        malfunction = true;
    }
    if (malfunction) {
        Console.WriteLine("CONTROL MALFUNCTION! CONTROL MALFUNCTION!");
        brakePercent = 0;
    }
    Console.WriteLine(" ");

    // step 3. calculations for everything
    brakeForce = 360 * brakePercent; 
    fuel -= -brakeForce / 3000;
    acceleration = 1.62 - (brakeForce / 8000);
    velocity += acceleration;
    height -= velocity + acceleration / 2;
}

// ending output
if (velocity < 4.0) {
    Console.WriteLine("You got a soft landing! Congratulations!");
}
if ((velocity >= 4.0) && (velocity <= 8.0)) {
    Console.WriteLine("Oof! You got a hard, hard landing! Still, congratulations on surviving!");
}
else {
    Console.WriteLine("Sorry! You were going too fast, so upon landing, you crashed and died! *play mario death sound*");
}