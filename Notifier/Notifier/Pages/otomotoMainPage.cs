using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Notifier.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Notifier.Pages
{
    public class otomotoMainPage
    {
        private ChromeDriver Driver;
        public otomotoMainPage(ChromeDriver driver)
        {
            Driver = driver;
        }

        //Elements
        public IWebElement Marka => Driver.FindElement(By.Id(@"select2-param571-container"));

        public List<Offer> GetCurrentPageArticles()
        {
            return Driver.FindElements(By.TagName("article")).Select(x => new Offer() { Id = x.GetAttribute("data-ad-id"), Url = x.GetAttribute("data-href") }).ToList();
        }
    }
}
