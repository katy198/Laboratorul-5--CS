using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab7CS.Page_and_Functionality
{
    class PTest2
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
            searchbar.SendKeys("computer");
        }

        public void Step3() => searchbar.SendKeys(Keys.Enter);

        public void Step4()
        {

            

            IList<IWebElement> all = driver.FindElements(By.ClassName("g"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }

            NUnit.Framework.TestContext.Progress.WriteLine("On this search are dispalyed " + i);
            
        }

        public void Step5()
        {
            NUnit.Framework.TestContext.Progress.WriteLine(" results!");
        }

    }
}
