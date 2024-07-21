public class Reminder
{
    public DateTime NextReminderDate { get; private set; }
    private int reminderIntervalMiles;

    public Reminder(int intervalMiles)
    {
        reminderIntervalMiles = intervalMiles;
    }

    public void ScheduleReminder(Car car)
    {
        int nextOilChangeMileage = car.CalculateNextOilChange();
        int currentMileage = car.GetCurrentMileage();
        int milesUntilNextChange = nextOilChangeMileage - currentMileage;

        if (milesUntilNextChange <= reminderIntervalMiles)
        {
            NextReminderDate = DateTime.Now.AddDays(1); // set reminder for next day
            Console.WriteLine($"Reminder scheduled for {NextReminderDate.ToShortDateString()}.");
        }
        else
        {
            NextReminderDate = DateTime.Now.AddDays((milesUntilNextChange / reminderIntervalMiles) * 30); // rough estimate
            Console.WriteLine($"Reminder scheduled for {NextReminderDate.ToShortDateString()}.");
        }
    }
}