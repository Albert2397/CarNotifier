﻿using System;
using System.Collections.Generic;
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
    }
}