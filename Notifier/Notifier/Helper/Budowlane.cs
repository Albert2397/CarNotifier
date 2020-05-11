using Notifier.Helper;
using Notifier.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace DealershipApp
{
    public class Budowlane : IPageHelper
    {
        //static void Main(string[] args)
        //{
        //    using (var driver = new ChromeDriver(Directory.GetCurrentDirectory()))
        //    {
        //        driver.Manage().Window.Maximize();
        //        driver.Navigate().GoToUrl("https://www.otomoto.pl/maszyny-budowlane/caterpillar/?search%5Bfilter_float_price%3Ato%5D=55000&search%5Bfilter_float_year%3Ato%5D=2015&search%5Border%5D=created_at_first%3Adesc&search%5Bcountry%5D=");
        //        Thread.Sleep(5000);

        //        var list = new otomotoMainPage(driver).GetCurrentPageArticles();

        //        //driver.Navigate().Refresh();
        //    }
        //    Console.ReadKey();
        //}

        private List<IWebElement> LastData = new List<IWebElement>();
        public void Initial()
        {
            Console.WriteLine("Budowlane initialized");

            //get list
            //set list
        }

        public void Reload()
        {
            Console.WriteLine("Budowlane reloaded");

            //get list
            //chceck diffrence
            //send emails
            //set list
        }
    }
}