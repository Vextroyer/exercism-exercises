public class SpaceAge
{
    private int ageInSeconds;
    public SpaceAge(int seconds)
    {
        this.ageInSeconds = seconds;
    }

    public double OnEarth() => this.ageInSeconds / 31_557_600.0d;

    public double OnMercury() => OnEarth() / 0.2408467d;

    public double OnVenus() => OnEarth() / 0.61519726d;

    public double OnMars() => OnEarth() / 1.8808158d;

    public double OnJupiter() => OnEarth() / 11.862615d;

    public double OnSaturn() => OnEarth() / 29.447498d;

    public double OnUranus() => OnEarth() / 84.016846d;

    public double OnNeptune() => OnEarth() / 164.79132d;
}