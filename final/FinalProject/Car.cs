public class Car : Vehicle
{
    public OilType OilType { get; private set; }
    private List<MaintenanceRecord> maintenanceRecords;

    public Car(string make, string model, OilType oilType, int currentMileage, int lastOilChangeMileage)
        : base(make, model, currentMileage, lastOilChangeMileage)
    {
        OilType = oilType;
        maintenanceRecords = new List<MaintenanceRecord>();
    }

    public override int CalculateNextOilChange()
    {
        // assuming oil change every 5000 miles
        return LastOilChangeMileage + 5000;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Car Make: {Make}, Model: {Model}, Current Mileage: {CurrentMileage}, Last Oil Change Mileage: {LastOilChangeMileage}, Oil Type: {OilType.Name}, Viscosity: {OilType.Viscosity}");
    }

    public void AddMaintenanceRecord(MaintenanceRecord record)
    {
        maintenanceRecords.Add(record);
        Console.WriteLine("Maintenance record added.");
    }

    public void DisplayMaintenanceRecords()
    {
        if (maintenanceRecords.Count == 0)
        {
            Console.WriteLine("No maintenance records found.");
        }
        else
        {
            Console.WriteLine("Maintenance Records:");
            foreach (var record in maintenanceRecords)
            {
                record.DisplayRecord();
            }
        }
    }
}