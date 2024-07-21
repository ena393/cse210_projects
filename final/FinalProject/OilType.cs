public class OilType
{
    public string Name { get; private set; }
    public string Viscosity { get; private set; }

    public OilType(string name, string viscosity)
    {
        Name = name;
        Viscosity = viscosity;
    }

    public void DisplayOilDetails()
    {
        Console.WriteLine($"Oil Type: {Name}, Viscosity: {Viscosity}");
    }
}