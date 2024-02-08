using Cortege;

PlanetList myList = new PlanetList();

var tuple = myList.getPlanet("Земля");
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.getPlanet("Лимония");
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.getPlanet("Венерия");
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.getPlanet("Планета 17");
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.getPlanet("Марс");
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.getPlanet("Венера");
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));

tuple = myList.getPlanet("Лимония");
Console.WriteLine((tuple.ordNum == null) ? tuple.fault : (myList.NameOfIndex(tuple.ordNum) + ", " +  tuple.ordNum + ", " +  tuple.equatorLen));
