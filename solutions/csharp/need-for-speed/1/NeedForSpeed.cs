class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven = 0;
    private int batteryPercentage = 100;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed,int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => this.batteryDrain > this.batteryPercentage;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if(this.batteryPercentage >= this.batteryDrain){
            this.batteryPercentage -= this.batteryDrain;
            this.distanceDriven += this.speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
}

class RaceTrack
{
    private int distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained()){
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}
