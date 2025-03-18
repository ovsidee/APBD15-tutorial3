using System.Security.Cryptography;

namespace APBD15_tut3;

public abstract class Container
{
    public static int Counter = 1;
    public int Id { get; set; } = Counter++;
    public double MassOfCargo { get; set; }
    public double Height { get; set; }
    public double TareWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxPayLoad { get; set; }

    public Container (char c, double massOfCargo, double height, double tareWeight, double depth, double maxPayLoad)
    {
        SerialNumber = $"KON-{c}-{Id}";
        MassOfCargo = massOfCargo;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        MaxPayLoad = maxPayLoad;
    }

    public virtual void LoadContainer(double massOfCargo)
    {
        if (massOfCargo > MaxPayLoad)
        {
            throw new OverfillException("Cannot load cargo, exceeds maximum capacity");
        } 
        MassOfCargo = massOfCargo;
    }

    public virtual void EmptyCargo()
    {
        MassOfCargo = 0;
    }
}