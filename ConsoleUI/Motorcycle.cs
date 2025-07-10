namespace ConsoleUI;

public class Motorcycle : Vehicule
{
    public bool HasSideCart {get; set;}
    public override void DriveAbstract()
    {
        throw new System.NotImplementedException();
    }

    public override void DriveVirtual()
    {
        throw new System.NotImplementedException();
    }
}