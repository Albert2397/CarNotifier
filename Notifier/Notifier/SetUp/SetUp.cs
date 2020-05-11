using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Timers;

namespace Notifier.SetUp
{
    public class SetUp
    {
        private static Timer aTimer;
        public static void StartTimeInterval()
        {
            // Create a timer and set a 5 minute interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 300000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
    
            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }
    }
}