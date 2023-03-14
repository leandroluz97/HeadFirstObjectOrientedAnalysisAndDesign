using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayApp
{
    public class Connection
    {
        public Station StationOne { get; set; }
        public Station StationTwo { get; set; }
        public string LineName { get; set; }

        public Connection(Station stationOne, Station stationTwo, string lineName)
        {
            StationOne = stationOne;
            StationTwo = stationTwo;
            LineName = lineName;
        }
        
    }
}
