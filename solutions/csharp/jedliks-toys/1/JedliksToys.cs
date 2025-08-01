class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int metersCovered = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {metersCovered} meters";

    public string BatteryDisplay() => batteryPercentage > 0 ? $"Battery at {batteryPercentage}%" : "Battery empty";

    public void Drive()
    {
        if (batteryPercentage > 0){
            batteryPercentage -= 1;
            metersCovered += 20;
        }
    }
}
