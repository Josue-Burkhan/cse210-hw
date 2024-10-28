abstract class Activity
{
    private DateTime date;
    private int duration;
    protected Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {this.GetType().Name} ({duration} min): Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
    }

    public int GetDuration() => duration;
}

class Running : Activity
{
    private double distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }
    public override double GetDistance() => distance;

    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;

    public override double GetPace() => GetDuration() / GetDistance();
}

class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }
    public override double GetDistance() => (speed * GetDuration()) / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;
}

class Swimming : Activity
{
    private int laps;
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }
    public override double GetDistance() => laps * 50 / 1000.0;

    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;

    public override double GetPace() => GetDuration() / GetDistance();
}
