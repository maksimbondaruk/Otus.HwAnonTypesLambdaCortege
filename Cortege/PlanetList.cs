namespace Cortege;
public class PlanetList
{
    static Planet venus = new Planet("Венера", 2, 38025, null);
    static Planet earth = new Planet("Земля", 3, 40075, venus.PlanetName);
    static Planet mars = new Planet("Марс", 4, 21344, earth.PlanetName);
    private int faultQty = 0;
    private List<Planet> innerSunOrbitList = new List<Planet>();
    public PlanetList()
    {
        innerSunOrbitList.Add(venus);
        innerSunOrbitList.Add(earth);
        innerSunOrbitList.Add(mars);
    }
    public (int? ordNum, int? equatorLen, string? fault) getPlanet(string planetName)
    {
        var tuple = checkPlanet(planetName);
        if (faultQty > 2) 
        {
            faultQty = 0;
            return (null, null, "Вы спрашиваете слишком часто");
        }
        return (tuple.ordNum, tuple.equatorLen, tuple.fault);
    }
   (int? ordNum, int? equatorLen, string? fault) checkPlanet (string planetName)
   {
        foreach (var planetCounter in innerSunOrbitList)
        {
            if (planetCounter.PlanetName == planetName)
            {
                return (planetCounter.OrdNumber, planetCounter.EquatorLength, null);
            }
        }
        faultQty++;
        return (null, null, "Не удалось найти планету " + planetName);
   }
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