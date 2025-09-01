namespace SpeedControl;

public class Vehicle(string licensePlate, double currentSpeed)
{
    public string LicensePlate { get; } = licensePlate;
    public double CurrentSpeed { get; private set; } = currentSpeed;

    public void UpdateSpeed(double newSpeed)
    {
        CurrentSpeed = newSpeed;
    }
}
