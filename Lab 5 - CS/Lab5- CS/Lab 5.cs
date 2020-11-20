using Lab5__CS.Extension;
using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Lab5CS
{
    public class Lab5
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\");

        }


        [Test]
        public void Test1Lab5()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("computer");
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("btnK")).Click();

        }

        [Test]
        public void Test2Lab5()
        {
            driver.Navigate().GoToUrl("https://ebay.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("gh-ac")).SendKeys("computer");
            driver.FindElement(By.Id("gh-ac")).Click();
            driver.FindElement(By.Id("gh-btn")).Click();
        }
    }
}