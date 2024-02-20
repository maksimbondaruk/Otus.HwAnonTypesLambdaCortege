namespace Lambda;
public class Planet
{
    public Planet(string planetName, int ordNumber, int equatorLength, string? prevPlanet)
    {
        PlanetName = planetName;
        OrdNumber = ordNumber;
        EquatorLength = equatorLength;
        PrevPlanet = prevPlanet;
    }
    public string PlanetName { get; }

    public int OrdNumber { get; }

    public int EquatorLength { get; }

    public string? PrevPlanet { get; }
}