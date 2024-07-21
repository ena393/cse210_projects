public class OilCalculator
{
    public double CalculateOilAmount(Car car)
    {
        // assume the oil amount is based on the car's engine size.
        string carModel = car.Model.ToLower();

        if (carModel.Contains("small"))
        {
            return 4.5;
        }
        else if (carModel.Contains("medium"))
        {
            return 5.0;
        }
        else if (carModel.Contains("large"))
        {
            return 5.5;
        }
        else
        {
            // default amount if car model doesn't match any specific criteria
            return 5.0;
        }
    }
}