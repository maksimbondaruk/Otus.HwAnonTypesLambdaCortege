string? firstPlanet = null;
var venus  = new
{
    PlanetName = "Венера",
    OrdNumber = 2,
    EquatorLength = 38025,
    PrevPlanet = firstPlanet
};
var earth = new
{
    PlanetName = "Земля",
    OrdNumber = venus.OrdNumber + 1,
    EquatorLength = 40075,
    PrevPlanet = venus.PlanetName
};
var mars = new
{
    PlanetName = "Марс",
    OrdNumber = earth.OrdNumber+1,
    EquatorLength = 21344,
    PrevPlanet = earth.PlanetName
};
var venus2  = new
{
    PlanetName = "Венера",
    OrdNumber = 2,
    EquatorLength = 38025,
    PrevPlanet = firstPlanet
};
Console.WriteLine("Планета "+ venus.PlanetName + " расположена " + venus.OrdNumber + "-й от Солнца. " +
                  "Длина экватора составляет " + venus.EquatorLength + ". Перед ней расположена планета Меркурий");
Console.WriteLine(venus.Equals(venus) ? venus.PlanetName + " эквивалентна Венере" : venus.PlanetName + " не эквивалентна Венере");

Console.WriteLine("Планета "+ earth.PlanetName + " расположена " + earth.OrdNumber + "-й от Солнца. " +
                  "Длина экватора составляет " + earth.EquatorLength + ". Перед ней расположена планета " + earth.PrevPlanet);
Console.WriteLine(earth.Equals(venus) ? earth.PlanetName + " эквивалентна Венере" : earth.PlanetName + " не эквивалентна Венере");
Console.WriteLine("Планета "+ mars.PlanetName + " расположена " + mars.OrdNumber + "-й от Солнца. " +
                  "Длина экватора составляет " + mars.EquatorLength + ". Перед ней расположена планета " + mars.PrevPlanet);
Console.WriteLine(mars.Equals(venus) ? mars.PlanetName + " эквивалентна Венере" : mars.PlanetName + " не эквивалентна Венере");
Console.WriteLine("Планета "+ venus2.PlanetName + " расположена " + venus2.OrdNumber + "-й от Солнца. " +
                  "Длина экватора составляет " + venus2.EquatorLength + ". Перед ней расположена планета Меркурий");
Console.WriteLine(venus2.Equals(venus) ? venus2.PlanetName + " эквивалентна Венере" : venus2.PlanetName + " не эквивалентна Венере");
Console.WriteLine("Equals - равенство значений earth / venus " + earth.Equals(venus));
Console.WriteLine("Equals - равенство значений venus / venus2  = " + venus.Equals(venus2));
Console.WriteLine("Равенство ссылок venus / venus2  = " + (venus == venus2));

