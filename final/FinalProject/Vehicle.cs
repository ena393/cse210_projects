public abstract class Vehicle
{
    public string Make { get; protected set; }
    public string Model { get; protected set; }
    public int CurrentMileage { get; protected set; }
    public int LastOilChangeMileage { get; protected set; }

    public Vehicle(string make, string model, int currentMileage, int lastOilChangeMileage)
    {
        Make = make;
        Model = model;
        CurrentMileage = currentMileage;
        LastOilChangeMileage = lastOilChangeMileage;
    }

    public abstract int CalculateNextOilChange();

    public void UpdateMileage(int mileage)
    {
        CurrentMileage = mileage;
    }

    public int GetCurrentMileage()
    {
        return CurrentMileage;
    }

    public void RecordOilChange(int mileage)
    {
        LastOilChangeMileage = mileage;
    }

    public abstract void DisplayDetails();
}