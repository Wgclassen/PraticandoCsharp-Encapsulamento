using SpeedControl;

Vehicle vehicle = new("ABC-1234", 0);
vehicle.UpdateSpeed(72.5);

Console.WriteLine("Vehicle: " + vehicle.LicensePlate);
Console.WriteLine("Current speed: " + vehicle.CurrentSpeed + " km/h");