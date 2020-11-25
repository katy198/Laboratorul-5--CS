using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7CS.Page_and_Functionality
{
    class PTest3
    {
        public IWebDriver driver;

        public void Step1()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\drivers\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        public IWebElement searchbar => driver.FindElement(By.Name("q"));


        public void Step2()
        {
            searchbar.Click();
            searchbar.SendKeys(" ");
        }

        public void Step3() => searchbar.SendKeys(Keys.Enter);

        public void ControlResult()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://www.google.com/");
        }

    }
}
