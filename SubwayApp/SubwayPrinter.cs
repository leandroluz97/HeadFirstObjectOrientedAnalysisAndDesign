using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayApp
{
    public class SubwayPrinter
    {
        public void PrintDirections(List<Connection> connections)
        {
            for (int i = 0; i < connections.Count; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine($"Get on the {connections[0].StationOne.Name} heading towards {connections[0].StationTwo.Name}");
                    continue;
                }
                if(connections[i].LineName == connections[i - 1].LineName)
                {
                    Console.WriteLine($"Continue {connections[i - 1].StationTwo.Name}...");
                }
                if(connections[i].LineName != connections[i + 1].LineName)
                {
                    Console.WriteLine($"When you get {connections[i].StationTwo.Name} get off {connections[i].LineName}");
                }
            }
        }
    }
}
