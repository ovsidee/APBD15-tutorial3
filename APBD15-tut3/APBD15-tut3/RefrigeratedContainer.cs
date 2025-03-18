namespace APBD15_tut3;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; set; }
    public double TemperatureOfContainer { get; set; }
    public Dictionary<string, double> TypeTemperature { get; set; }
    public RefrigeratedContainer(string productType, double temperatureOfContainer, double height,
        double tareWeight, double depth, double maxPayLoad)
        : base('C', height, tareWeight, depth, maxPayLoad)
    {
        TypeTemperature = new Dictionary<string, double>();
        TypeTemperature.Add("Bananas", 13.3);
        TypeTemperature.Add("Chocolate", 18);
        TypeTemperature.Add("Fish", 2);
        TypeTemperature.Add("Meat", -15);
        TypeTemperature.Add("Ice cream", -1);
        TypeTemperature.Add("Frozen pizza", -30);
        TypeTemperature.Add("Cheese", 7.2);
        TypeTemperature.Add("Sausages", 5);
        TypeTemperature.Add("Butter", 20.5);
        TypeTemperature.Add("Eggs", 19);
        
        if (!TypeTemperature.ContainsKey(productType))
        {
            throw new ArgumentException("Product type is not supported");
        }
        
        if (temperatureOfContainer < TypeTemperature[productType])
        {
            throw new ArgumentException($"Temperature of the product cannot be lower than the temperature required by: \"{productType}\"");
        }
        
        ProductType = productType;
        TemperatureOfContainer = temperatureOfContainer;
    }
}