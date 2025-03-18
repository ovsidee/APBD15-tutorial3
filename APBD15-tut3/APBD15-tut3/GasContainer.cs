namespace APBD15_tut3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }  
    public GasContainer(double pressure, double height, double tareWeight, double depth, double maxPayLoad)
        : base('G', height, tareWeight, depth, maxPayLoad)
    {
        Pressure = pressure;
    }
    public void SendNotification()
    {
       Console.WriteLine($"Hazard alert! Container: \"{SerialNumber}\"");
    }
    public override void EmptyCargo()
    {
        MassOfCargo *= 0.05;
    }
}