namespace Lambda;
public class PlanetList
{
    static Planet venus = new Planet("Венера", 2, 38025, null);
    static Planet earth = new Planet("Земля", 3, 40075, venus.PlanetName);
    static Planet mars = new Planet("Марс", 4, 21344, earth.PlanetName);
    internal int faultQty = 0;
    public delegate string? PlanetValidator(string planetName);

    internal static List<Planet> innerSunOrbitList = new List<Planet>();
    public PlanetList()
    {
        innerSunOrbitList.Add(venus);
        innerSunOrbitList.Add(earth);
        innerSunOrbitList.Add(mars);
    }
    public (int? ordNum, int? equatorLen, string? fault) GetPlanet(string planetName, PlanetValidator planetCheckFunc)
    {
        var planetCheckFuncResultString = planetCheckFunc(planetName);
        if (planetCheckFuncResultString == null)
        {
            foreach (var planetCounter in innerSunOrbitList)
            {
                if (planetCounter.PlanetName == planetName)
                {
                    return (planetCounter.OrdNumber, planetCounter.EquatorLength, null);
                }
            }
        }
        return (null, null, planetCheckFuncResultString);
    }
    /*public string? PlanetChecker(string planetName)
    {
        faultQty++;
        if (faultQty > 2)
        {
            faultQty = 0;
            return ("Вы спрашиваете слишком часто");
        }
        foreach (var planetCounter in innerSunOrbitList)
        {
            if (planetCounter.PlanetName == planetName)
            {
                return null;
            }
        }
        return ("Не удалось найти планету " + planetName);
    }
    */
    public string? NameOfIndex(int? ordNum)
    {
        if (ordNum != null)
        {
            foreach (var planetCounter in innerSunOrbitList)
            {
                if (planetCounter.OrdNumber == ordNum)
                {
                    return (planetCounter.PlanetName);
                }
            }
        }
        return null;
    }
}