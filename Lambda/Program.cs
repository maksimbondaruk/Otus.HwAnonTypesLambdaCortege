using Lambda;
PlanetList myList = new PlanetList();
var tuple = myList.GetPlanet("Земля", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Земля", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Лимония", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Лимония", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Венерия", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Планета 17", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Марс", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.GetPlanet("Венера", myList.PlanetChecker);
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));
