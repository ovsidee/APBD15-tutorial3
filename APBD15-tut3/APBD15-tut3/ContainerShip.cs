namespace APBD15_tut3;

public class ContainerShip
{
    public int MaximumNumberOfContainers { get; set; }
    public double MaximumWeightOfContainers { get; set; }
    public double MaximumSpeed{ get; set; }
    public List<Container> Containers { get; set; } = new List<Container>();

    public ContainerShip(int maximumNumberOfContainers, double maximumWeightOfContainers, double maximumSpeed)
    {
        MaximumNumberOfContainers = maximumNumberOfContainers;
        MaximumWeightOfContainers = maximumWeightOfContainers;
        MaximumSpeed = maximumSpeed;
    }

    public void RemoveContainerFromShip(Container container)
    {
        Containers.Remove(container);
    }

    public void AddContainerToShip(Container container)
    {
        if (!CanAddContainer(container))
        {
            throw new InvalidOperationException("Cannot add container: Exceeds ship capacity.");
        }
        Containers.Add(container);
    }

    public bool CanAddContainer(Container container)
    {
        double totalWeight = Containers.Sum(c => c.TareWeight + c.MassOfCargo);
        
        if (Containers.Count >= MaximumNumberOfContainers)
        {
            return false;
        }
        
        if (totalWeight + container.TareWeight + container.MassOfCargo > MaximumWeightOfContainers)
        {
            return false;
        }
        
        return true;
    }

    public void AddListOfContainersToShip(List<Container> containers)
    {
        foreach (var container in containers)
        {
            AddContainerToShip(container);
        }
    }

    public void ReplaceContainer(Container oldContainer, Container newContainer)
    {
        if (!CanAddContainer(newContainer))
        {
            throw new InvalidOperationException("Cannot replace container: New container exceeds ship capacity.");
        }
        Containers.Remove(oldContainer);
        Containers.Add(newContainer);
    }

    public void TransferContainerBetweenTwoShips(Container container, ContainerShip containerShipOld, ContainerShip containerShipNew)
    {
        if (!containerShipNew.CanAddContainer(container))
        {
            throw new InvalidOperationException("Cannot transfer container: Exceeds new ship's capacity.");
        }
        containerShipOld.RemoveContainerFromShip(container);
        containerShipNew.AddContainerToShip(container);
    }

    public void PrintShipInformation()
    {
        Console.WriteLine($"Ship Capacity: \"{MaximumNumberOfContainers}\" containers, \"{MaximumWeightOfContainers}\" kg max weight");
        Console.WriteLine($"Current Containers: \"{Containers.Count}\"");
        
        double totalWeight = Containers.Sum(c => c.TareWeight + c.MassOfCargo);
        Console.WriteLine($"Total Weight: \"{totalWeight}\" kg");
        
        foreach (var container in Containers)
        {
            Console.WriteLine($"Container: \"{container.SerialNumber}\", Tare Weight = \"{container.TareWeight}\" kg, Cargo Weight = \"{container.MassOfCargo}\" kg");
        }
    }
}
