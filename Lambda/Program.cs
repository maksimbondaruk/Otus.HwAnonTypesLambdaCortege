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
var (orderNumber, equatorLength, fault) = myList.GetPlanet("Земля", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Земля", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Лимония", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Лимония", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Венерия", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Планета 17", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Венерия", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Марс", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Земля", checkerLambda);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

Console.WriteLine();
Console.WriteLine("Тест на Лимонию");
Console.WriteLine();

(orderNumber, equatorLength, fault) = myList.GetPlanet("Земля", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Земля", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Лимония", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Лимония", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Венерия", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Планета 17", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Венерия", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Марс", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));

(orderNumber, equatorLength, fault) = myList.GetPlanet("Земля", checkerLambdaforLemony);
Console.WriteLine((orderNumber == null) ? fault : (myList.NameOfIndex(orderNumber) + ", " + orderNumber + ", " + equatorLength));
