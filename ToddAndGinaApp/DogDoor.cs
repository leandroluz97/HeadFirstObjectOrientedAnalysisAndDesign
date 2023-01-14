using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ToddAndGinaApp
{
    public class DogDoor
    {
        System.Timers.Timer aTimer;
        public bool isOpen = false;
        public List<Bark> AllowedBarks { get; }

        public void Close() { isOpen = false; }

        public void AddAllowedBark(Bark bark)
        {
            AllowedBarks.Add(bark);
        }
        public void Open() 
        { 
            isOpen = true;
            setTimer();
        }
        private void setTimer()
        {
            aTimer = new System.Timers.Timer(5000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
            aTimer.Start();
        }
        private void OnTimedEvent(Object? source, ElapsedEventArgs e)
        {
            aTimer.Stop();
            Close();
            Console.WriteLine("Door close after 5 sec");
        }
    }
}
