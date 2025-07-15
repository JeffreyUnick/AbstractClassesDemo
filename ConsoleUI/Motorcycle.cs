using System;

namespace ConsoleUI;

public class Motorcycle : Vehicule
{
    public bool HasSideCart {get; set;}
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle Drive");
        ;
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle Drive virtually");
        ;
    }
}