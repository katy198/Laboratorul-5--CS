using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_lab6.Pages
{
    class SocialMediaPage
    {
        public SocialMediaPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver { get; }


        public IWebElement siteBtn => driver.FindElement(By.CssSelector("body > div.footer > div > div.col-md-3.footer-left > ul > li:nth-child(1) > a > div.front"));

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Element = driver.FindElement(By.ClassName("footer"));
            js.ExecuteScript("arguments[0].scrollIntoView();", Element);
        }

        public void AccesMedia() => siteBtn.Click();

        public void CompareResult()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "facebook.com");
        }

    }
}
