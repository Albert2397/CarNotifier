using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
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

        public ReadOnlyCollection<IWebElement> GetCurrentPageArticles()
        {
            return Driver.FindElements(By.TagName("article"));
        }
    }
}
