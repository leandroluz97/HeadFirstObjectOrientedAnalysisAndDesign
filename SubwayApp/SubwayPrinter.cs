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
                    Console.WriteLine($"Get on the {connections[i].StationOne.Name} heading towards {connections[i].StationTwo.Name}");
                    continue;
                }
                if(connections[i].LineName == connections[i - 1].LineName)
                {
                    Console.WriteLine($"Continue {connections[i - 1].StationTwo.Name}...");
                }
                if((i + 1) >= connections.Count - 1)
                {
                    Console.WriteLine($"Get out and enjoy {connections[i - 1].StationTwo.Name} ");
                    break;
                }
                if(connections[i].LineName != connections[i + 1].LineName)
                {
                    Console.WriteLine($"When you get {connections[i].StationTwo.Name} get off {connections[i].LineName}");
                    Console.WriteLine($"Switch over to the {connections[i].StationTwo.Name} heading towards {connections[i].LineName}");
                }
            }
        }
    }
}
