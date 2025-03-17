namespace APBD15_tut3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardousCargo { get; }
    public LiquidContainer(bool isHazardousCargo, double massOfCargo, double height, double tareWeight, double depth, double maxPayLoad)
        : base(massOfCargo, height, tareWeight, depth, maxPayLoad)
    {
        IsHazardousCargo = isHazardousCargo;
        SerialNumber = $"KON-L-{Id}";
    }
    
    public void SendNotification()
    {
        Console.WriteLine($"Hazard alert! Container: {SerialNumber} is overloaded or improperly loaded!");
    }

    public override void LoadContainer(double massOfCargo)
    {
        double allowedCapacity = 0;
        if (IsHazardousCargo) {
            allowedCapacity = MaxPayLoad * 0.5;
        }
        else {
            allowedCapacity = MaxPayLoad * 0.9;
        }
        if (massOfCargo > allowedCapacity) {
            SendNotification();
            throw new OverfillException("Cargo exceeds allowed capacity of {allowedCapacity} kg.");
        }
        base.LoadContainer(massOfCargo);
    }
}