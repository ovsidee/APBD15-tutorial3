using APBD15_tut3;

GasContainer gasContainer1 = new GasContainer(10, 250, 200, 250, 250);
gasContainer1.LoadContainer(249);
Console.WriteLine("before: " + gasContainer1.MassOfCargo);
gasContainer1.LoadContainer(1);
Console.WriteLine("now: " +gasContainer1.MassOfCargo);
Console.WriteLine("Serial number of Gas Container1: " + gasContainer1.SerialNumber);

