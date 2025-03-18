namespace APBD15_tut3;

public class ContainerShip
{
    public int MaximumNumberOfContainers { get; set; }
    public double MaximumWeightOfContainers { get; set; }
    public List<Container> Containers { get; set; }
    
    public ContainerShip(Container container, int maximumNumberOfContainers, double maximumWeightOfContainers)
    {
        MaximumNumberOfContainers = maximumNumberOfContainers;
        MaximumWeightOfContainers = maximumWeightOfContainers;
        Containers = new List<Container>();
        Containers.Add(container);
    }
}