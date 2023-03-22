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
        public Dictionary<string, object> Network { get; set; }

        public Subway()
        {
            Stations = new List<Station>();
            Connections = new List<Connection>();
            Network = new Dictionary<string, object>();
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

                AddConnection(stationOne, stationTwo);
                AddConnection(stationTwo, stationOne);
            }
            else
            {
                throw new Exception($"Either {nameof(stationOneName)} or {nameof(stationTwoName)} don't exist!");
            }
        }

        public void AddConnection(Station stationOne, Station stationTwo)
        {
            if(Network.ContainsKey(stationOne.Name))
            {
                List<Station> stationOneValues = (List<Station>)Network[stationOne.Name];
                if (stationOneValues.Contains(stationTwo))
                {
                    Network[stationOne.Name] = stationOneValues;
                }
            }
            else
            {
                List<Station> stationTwoValues = new List<Station>();
                stationTwoValues.Add(stationTwo);
                Network.Add(stationOne.Name, stationTwoValues);
            }
        }
        
        public List<Connection> GetDirections(string startStationName, string endStationName)
        {
            if(HasStation(startStationName) || HasStation(endStationName))
            {
                throw new Exception("Stations entered so not exist on this subway");
            }

            Station start = new Station(startStationName);
            Station end = new Station(endStationName);
            List<Connection> route = new List<Connection>();
            List<Station> reacheableStations = new List<Station>();
            Dictionary<string, Station> previousStations = new Dictionary<string, Station>();

            List<Station> neighbors = (List<Station>)Network[startStationName];
            foreach (Station station in neighbors)
            {
                if (station.Equals(end))
                {
                    route.Add(GetConnection(start, end));
                    return route;
                }
                else
                {
                    reacheableStations.Add(station);
                    previousStations.Add(station.Name, start);
                }
            }
            List<Station> nextStation = new List<Station>();
            nextStation.AddRange(neighbors);
            Station currentStation = start;

            for (int i = 1; i < Stations.Count; i++)
            {
                List<Station> tempNextStation = new List<Station>();
                foreach (Station next in nextStation)
                {
                    reacheableStations.Add(next);
                    currentStation = next;
                    List<Station> currentNeighbors = (List<Station>)Network[currentStation.Name];
                    foreach(Station currNeighbor in currentNeighbors)
                    {
                        if (currNeighbor.Equals(end))
                        {
                            reacheableStations.Add(currNeighbor);
                            previousStations[currNeighbor.Name] = currentStation;
                            break;
                        }
                        else if (!reacheableStations.Contains(currNeighbor))
                        {
                            reacheableStations.Add(currNeighbor);
                            tempNextStation.Add(currNeighbor);
                            previousStations[currNeighbor.Name] = currentStation;
                        }
                    }   
                }
                nextStation = tempNextStation;
            }

            bool keepLooping = true;
            Station keyStation = end;
            Station currStation;

            while (keepLooping)
            {
                currStation = (Station)previousStations[keyStation.Name];
                route.Insert(0, GetConnection(currStation, keyStation));
                if (start.Equals(currStation))
                {
                    keepLooping = false;
                }
                keyStation = currStation;
            }

            return route;
        }

        public Connection GetConnection(Station stationOne, Station stationTwo)
        {
            foreach (Connection connection in Connections)
            {
                Station one = connection.StationOne;
                Station two = connection.StationTwo;
                if(stationOne.Equals(one) && stationTwo.Equals(two))
                {
                    return connection;
                }
            }
            return null;
        }

    }
}
