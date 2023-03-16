using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayApp
{
    public class Subway
    {
        public List<Station> Stations { get; set; }
        public List<Connection> Connections { get; set; }

        public Subway()
        {
            Stations = new List<Station>();
            Connections = new List<Connection>();
        }

        public void AddStation(string stationName)
        {
            if(!HasStation(stationName))
            {
                Station station = new Station(stationName);
                Stations.Add(station);
            }
            
        }

        public  bool HasStation(string stationName)
        {
            return Stations.Contains(new Station(stationName));
        }
        public void AddConnection(string stationOneName, string stationTwoName, string lineName)
        {

            bool one = HasStation(stationOneName);
            bool two = HasStation(stationTwoName);

            if (HasStation(stationOneName) && HasStation(stationTwoName))
            {
                Station stationOne = new Station(stationOneName);
                Station stationTwo = new Station(stationTwoName);  
                Connection connection  = new Connection(stationOne, stationTwo, lineName);
                Connections.Add(connection);
            }
            else
            {
                throw new Exception($"Either {nameof(stationOneName)} or {nameof(stationTwoName)} don't exist!");
            }
        }

    }
}
