using System.Collections.Generic;

namespace ConsoleUI;

public abstract class Vehicule
{
    public string Year { get; set; } = "Empty";
    public string Make { get; set; } = "Empty";
    public string Model { get; set; } = "Empty";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        
    }
}