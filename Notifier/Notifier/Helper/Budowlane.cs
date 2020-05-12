using Notifier.Helper;
using Notifier.Models;
using Notifier.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace DealershipApp
{
    public class Budowlane: IPageHelper
    {
        private List<Offer> LastData = new List<Offer>();
        public void Initial()
        {
            Console.WriteLine("Budowlane initialized");

            //get and set list
            LastData = GetCurrentList();
        }

        public void Reload()
        {
            Console.WriteLine("Budowlane reloaded");

            //get list
            var data = GetCurrentList();

            //check diffrence
            var difference = GetNewData(LastData, data).ToList();
            foreach (var item in difference)

            //send emails
            {
                EmailSender.Send("albert.kkk@interia.pl", item.Url);
                Console.WriteLine("New ID: " + item.Id + " URL: " + item.Url);
            }

            //set list
            LastData = data;
        }

        private List<Offer> GetCurrentList()
        {
                using (var driver = new ChromeDriver(Directory.GetCurrentDirectory()))
                {
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl("https://www.otomoto.pl/osobowe/?search%5Border%5D=created_at_first%3Adesc&search%5Bbrand_program_id%5D%5B0%5D=&search%5Bcountry%5D=");
                    //driver.Navigate().GoToUrl("https://www.otomoto.pl/maszyny-budowlane/caterpillar/?search%5Bfilter_float_price%3Ato%5D=55000&search%5Bfilter_float_year%3Ato%5D=2015&search%5Border%5D=created_at_first%3Adesc&search%5Bcountry%5D=");
                    Thread.Sleep(10000);

                    return new otomotoMainPage(driver).GetCurrentPageArticles();
                }
        }

        private IEnumerable<Offer> GetNewData(List<Offer> currentlist, List<Offer> newlist)
        {
            foreach (var item in newlist)
            {
                if (!currentlist.Any(x => x.Id == item.Id))
                {
                    yield return item;
                }
            }
        }
    }
}