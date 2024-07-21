public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never completed, just add points
    }

    public override string GetStatus()
    {
        return "[∞]";
    }
}