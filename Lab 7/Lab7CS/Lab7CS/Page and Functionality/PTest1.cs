using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7CS.Page_and_Functionality
{
    class PTest1
    {
        public IWebDriver driver;

        public void Step1()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\drivers\");
            driver.Manage().Window.Maximize();
        }
        public void Step2() => driver.Manage().Window.Maximize();

        public void Step3() => driver.Navigate().GoToUrl("https://www.google.co.in");

        public void ControlResult()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://www.google.co.in/");
        }


    }
}
