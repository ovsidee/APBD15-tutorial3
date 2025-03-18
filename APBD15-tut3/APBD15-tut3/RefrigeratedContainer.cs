namespace APBD15_tut3;

public class RefrigeratedContainer : Container, IHazardNotifier
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }
    public Dictionary<string, double> TypeTemperature { get; set; }
    
    public RefrigeratedContainer(string productType, double temperature, double massOfCargo, double height, double tareWeight, double depth, double maxPayLoad) 
        : base('C', massOfCargo, height, tareWeight, depth, maxPayLoad)
    {
        TypeTemperature = new Dictionary<string, double>();
        if (temperature < TypeTemperature[productType])
        {
            throw new OverfillException("Temperature of the product is too low");
        }
        TypeTemperature.Add(productType, temperature);
        
        ProductType = productType;
        Temperature = temperature;
    }

    public void SendNotification()
    {
        Console.WriteLine($"Hazard alert! Container: {SerialNumber}");
    }
}