public class Garage
{
    private List<Car> cars;

    public Garage()
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
        Console.WriteLine($"Car {car.Make} {car.Model} added to the garage.");
    }

    public void RemoveCar(Car car)
    {
        if (cars.Remove(car))
        {
            Console.WriteLine($"Car {car.Make} {car.Model} removed from the garage.");
        }
        else
        {
            Console.WriteLine($"Car {car.Make} {car.Model} not found in the garage.");
        }
    }

    public void ListCars()
    {
        if (cars.Count == 0)
        {
            Console.WriteLine("No cars in the garage.");
        }
        else
        {
            Console.WriteLine("Cars in the garage:");
            foreach (var car in cars)
            {
                car.DisplayDetails();
            }
        }
    }

    public Car FindCar(string make, string model)
    {
        foreach (var car in cars)
        {
            if (car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
                car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
            {
                return car;
            }
        }
        Console.WriteLine($"Car {make} {model} not found in the garage.");
        return null;
    }

    public List<Car> FindAllCars()
    {
        return cars;
    }
}