

using SubwayApp;
using System;
using System.IO;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string path = @"D:\Code\HeadFirstObjectOrientedAnalysisAndDesign\SubwayApp\file\subwayfile.txt";
        SubwayLoader subwayLoader = new SubwayLoader();
        //Console.WriteLine("Empty Version");
        //foreach (Connection connect in subwayLoader.Subway.Connections)
        //{
        //    Console.WriteLine($"Connection name: {connect.LineName}");
        //}
        //foreach (Station station in subwayLoader.Subway.Stations)
        //{
        //    Console.WriteLine($"Station name: {station.Name}");
        //}
        subwayLoader.LoadFromFile(path);
        
        Console.WriteLine("Final Version");
        foreach (Connection connect in subwayLoader.Subway.Connections)
        {
            Console.WriteLine($"Connection name: {connect.LineName}");
        }
        foreach (var station in subwayLoader.Subway.Stations)
        {
            Console.WriteLine($"Station name: {station.Name}");
        }

        var printer =  new SubwayPrinter();
      
        Station station1 = new Station("XHTML Expressway");
        Station station2 = new Station("Infinite Circle");
        Station station3 = new Station("Infinite Circle");
        Station station4 = new Station("Head First Theater");
        Station station5 = new Station("Head First Theater");
        Station station6 = new Station("DRY drive");
        Station station7 = new Station("DRY drive");
        Station station8 = new Station("Web Design Way");
        Station station9 = new Station("Web Design Way");
        Station station10 = new Station("EJB Estates");
        Station station11 = new Station("EJB Estates");
        Station station12 = new Station("JSP Junction");
        
        var connections = new List<Connection>()
        {
            new Connection(station1, station2, "Rumbaugh Line"),
            new Connection(station2, station3, "Rumbaugh Line"),
            new Connection(station3, station4, "Meyer Line"),
            new Connection(station4, station5, "Meyer Line"),
            new Connection(station5, station6, "Wirfs-Brock"),
            new Connection(station6, station7, "Wirfs-Brock"),
            new Connection(station7, station8, "Wirfs-Brock"),
            new Connection(station8, station9, "Liskov Line"),
            new Connection(station9, station10, "Liskov Line"),
            new Connection(station10, station11, "Liskov Line"),
            new Connection(station11, station12, "Liskov Line"),
    };

        printer.PrintDirections(connections);




    }
}
