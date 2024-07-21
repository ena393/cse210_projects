using System.Timers;

public class Scheduler
{
    private System.Timers.Timer timer;
    private int reminderIntervalMiles;
    private Car car;
    private User user;

    public Scheduler(int intervalMiles, Car car, User user)
    {
        reminderIntervalMiles = intervalMiles;
        this.car = car;
        this.user = user;

        // set timer to check every day (86400000 milliseconds)
        timer = new System.Timers.Timer(86400000);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        CheckReminder();
    }

    private void CheckReminder()
    {
        int nextOilChangeMileage = car.CalculateNextOilChange();
        int currentMileage = car.GetCurrentMileage();
        int milesUntilNextChange = nextOilChangeMileage - currentMileage;

        if (milesUntilNextChange <= reminderIntervalMiles)
        {
            user.SendReminder(car);
        }
    }

    public void Start()
    {
        timer.Start();
    }

    public void Stop()
    {
        timer.Stop();
    }
}