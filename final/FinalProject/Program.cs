using System;

class Program
{
    static void Main(string[] args)
    {
        Garage garage = new Garage();

        // prompt user for info
        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();

        Console.WriteLine("Enter your email:");
        string userEmail = Console.ReadLine();

        User carOwner = new User(userName, userEmail);

        // add cars to garage
        while (true)
        {
            Console.WriteLine("Enter your car make (or type 'done' to finish):");
            string carMake = Console.ReadLine();
            if (carMake.ToLower() == "done") break;

            Console.WriteLine("Enter your car model:");
            string carModel = Console.ReadLine();

            Console.WriteLine("Enter your car's current mileage:");
            int currentMileage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your car's last oil change mileage:");
            int lastOilChangeMileage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the type of oil your car uses:");
            string oilName = Console.ReadLine();

            Console.WriteLine("Enter the viscosity of the oil:");
            string oilViscosity = Console.ReadLine();

            OilType oilType = new OilType(oilName, oilViscosity);

            Car userCar = new Car(carMake, carModel, oilType, currentMileage, lastOilChangeMileage);

            garage.AddCar(userCar);

            // create scheduler with interval of 500 miles
            Scheduler scheduler = new Scheduler(500, userCar, carOwner);

            scheduler.Start();

            // add maintenance record
            Console.WriteLine("Enter the date of the last maintenance (yyyy-mm-dd):");
            DateTime maintenanceDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the type of maintenance:");
            string maintenanceType = Console.ReadLine();

            Console.WriteLine("Enter any additional notes:");
            string notes = Console.ReadLine();

            MaintenanceRecord record = new MaintenanceRecord(maintenanceDate, maintenanceType, notes);
            userCar.AddMaintenanceRecord(record);

            // calculate amount of oil needed
            OilCalculator oilCalculator = new OilCalculator();
            double oilAmount = oilCalculator.CalculateOilAmount(userCar);
            Console.WriteLine($"The amount of oil needed for your car is: {oilAmount} liters.");
        }

        // list all cars in garage
        garage.ListCars();

        // display maintenance records for all cars in garage
        foreach (var car in garage.FindAllCars())
        {
            car.DisplayMaintenanceRecords();
        }

        // keep console open
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}