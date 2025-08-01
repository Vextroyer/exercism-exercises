static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) return 0.00;
        else if (1 <= speed && speed <= 4) return 1.00;
        else if (5 <= speed && speed <= 8) return 0.90;
        else if (speed == 9) return 0.80;
        else return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return 221 * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) (ProductionRatePerHour(speed) / 60.0);
    }
}
