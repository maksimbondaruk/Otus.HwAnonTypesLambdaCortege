using Lambda;
PlanetList myList = new PlanetList();

PlanetList.PlanetValidator checkerLambda = (string planetName) =>
{
    myList.faultQty++;
    if (myList.faultQty > 2)
    {
        myList.faultQty = 0;
        return ("Вы спрашиваете слишком часто");
    }
    foreach (var planetCounter in PlanetList.innerSunOrbitList)
    {
        if (planetCounter.PlanetName == planetName)
        {
            return null;
        }
    }
    return ("Не удалось найти планету " + planetName);
};

PlanetList.PlanetValidator checkerLambdaforLemony = (string planetName) =>
{
    //foreach (var planetCounter in PlanetList.innerSunOrbitList)
    //{
        if (planetName != "Лимония")
        {
            return null;
        }
    //}
    return ("Это запретная планета");
};

//var tuple = myList.GetPlanet("Земля", myList.PlanetChecker);
var tuple = myList.GetPlanet("Земля", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Земля", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Лимония", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Лимония", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Венерия", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Планета 17", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Марс", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Венера", checkerLambda);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

Console.WriteLine();
Console.WriteLine("Тест на Лимонию");
Console.WriteLine();

tuple = myList.GetPlanet("Земля", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));

tuple = myList.GetPlanet("Земля", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));

tuple = myList.GetPlanet("Лимония", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));

tuple = myList.GetPlanet("Лимония", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));

tuple = myList.GetPlanet("Венерия", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));

tuple = myList.GetPlanet("Планета 17", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));

tuple = myList.GetPlanet("Марс", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));

tuple = myList.GetPlanet("Венера", checkerLambdaforLemony);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " + tuple.ordNum + ", " + tuple.equatorLen));