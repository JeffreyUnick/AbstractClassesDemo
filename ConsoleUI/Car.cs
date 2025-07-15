using System;

namespace ConsoleUI;

public class Car : Vehicule
{
    public bool HasTrunk { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("Car Drive");
        ;
    }
}