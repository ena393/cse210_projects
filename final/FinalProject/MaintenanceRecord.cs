using System;

public class MaintenanceRecord
{
    public DateTime DateOfMaintenance { get; private set; }
    public string MaintenanceType { get; private set; }
    public string Notes { get; private set; }

    public MaintenanceRecord(DateTime dateOfMaintenance, string maintenanceType, string notes)
    {
        DateOfMaintenance = dateOfMaintenance;
        MaintenanceType = maintenanceType;
        Notes = notes;
    }

    public void DisplayRecord()
    {
        Console.WriteLine($"Date: {DateOfMaintenance.ToShortDateString()}, Type: {MaintenanceType}, Notes: {Notes}");
    }
}