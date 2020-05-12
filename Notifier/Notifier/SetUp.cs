using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Timers;
using Notifier.Helper;
using DealershipApp;

namespace Notifier
{
    public static class SetUp
    {
        private static List<IPageHelper> pages = new List<IPageHelper>();
        private static Timer aTimer;
        public static void StartTimeInterval()
        {
            SetStartData();
            // Create a timer and set a 5 minute interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 60000;
            //aTimer.Interval = 300000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
    
            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        private static void SetStartData()
        {
            pages.Add(new Budowlane());
            
            foreach (var page in pages)
            {
                page.Initial();
            }
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            foreach (var page in pages)
            {
                page.Reload();
            }
        }
    }
}