

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



    }
}
