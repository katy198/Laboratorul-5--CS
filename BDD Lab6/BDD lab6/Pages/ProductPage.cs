using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_lab6.Pages
{
    class ProductPage
    {

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver { get; }

        public IWebElement womwearbtn => driver.FindElement(By.LinkText("Women's wear"));

        public IWebElement wonclothbtn => driver.FindElement(By.LinkText("Women Clothing"));

        public IWebElement blkbasicshortsbtn => driver.FindElement(By.LinkText("Black Basic Shorts"));


        public void WomWearBtnChoose() => womwearbtn.Click();
        public void WomClothBtnChoose() => wonclothbtn.Click();

        public void ProductChoose() => blkbasicshortsbtn.Click();

        public void CompareResult()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/black-basic-shorts.html");
        }
    }
}
