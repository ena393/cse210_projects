public class User
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void SendReminder(Car car)
    {
        int nextOilChangeMileage = car.CalculateNextOilChange();
        string subject = "Oil Change Reminder";
        string body = $"Hi {Name},\n\nJust a reminder that your car is due for an oil change at {nextOilChangeMileage} miles.\n\nBest,\nThe Car Maintenance App";

        Console.WriteLine("Pretending to send an email...");
        Console.WriteLine($"To: {Email}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body:\n{body}");
    }
}