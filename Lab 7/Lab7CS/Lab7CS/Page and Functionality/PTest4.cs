using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7CS.Page_and_Functionality
{
    class PTest4
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
            searchbar.SendKeys("polnolunie");
        }


        public void Step3() => searchbar.SendKeys(Keys.Enter);

        public void ControlResult()
        {
            driver.PageSource.Contains("Возможно, вы имели в виду:");
            
        }
    }
}
