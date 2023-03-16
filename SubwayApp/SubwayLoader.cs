using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SubwayApp
{
    public class SubwayLoader
    {
        public Subway Subway { get; set; }
        public SubwayLoader()
        {
            Subway = new Subway();
        }

        public void LoadFromFile(string filePath)
        {
            string[] lines =  File.ReadAllLines(filePath);
            LoadStations(lines);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("line", StringComparison.CurrentCultureIgnoreCase))
                {
                    LoadConnection(lines, lines[i], i + 1);
                }
            }


        }

        public void LoadStations(string[] lines)
        {
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line)) break;
                Subway.AddStation(line);
            }
        }

        public void LoadConnection(string[] lines, string lineName, int startLine)
        {
            int stationOne = startLine;
            int stationTwo;
            for (int i = startLine; i < lines.Length - 1; i++)
            {
                stationTwo = i + 1;
                if (string.IsNullOrEmpty(lines[stationTwo])) break;
                Subway.AddConnection(lines[stationOne], lines[stationTwo], lineName);
                stationOne = stationTwo;
            }
        }

    }
}
