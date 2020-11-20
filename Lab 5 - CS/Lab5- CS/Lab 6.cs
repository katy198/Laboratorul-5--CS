using Lab5__CS.Extension;
using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Lab5CS
{
    public class Lab6
    {
         private IWebDriver driver;
        [SetUp]
         public void Setup()
         {
             driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\");

         }

        [Test]
        public void Test1Lab6()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            driver.FindElement(By.Name("search")).SendKeys("jeans");
            driver.FindElement(By.Name("search")).SendKeys(Keys.Enter);
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/clothes-jeans.html");


        }

        [Test]
        public void Test2Lab6()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            driver.FindElement(By.LinkText("Sign Up")).Click();
            IWebElement signModal = driver.WaitForElementToAppear(10, By.Id("myModal"));
            IWebElement txtname = driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div.styled-input.agile-styled-input-top > input[type=text]"));
            driver.WaitForElementToBeClickable(5, txtname).SendKeys("Ecaterina");
            IWebElement txtemail = driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div:nth-child(2) > input[type=email]"));
            driver.WaitForElementToBeClickable(5, txtemail).SendKeys("ecaterina.pavlenco@ati.utm.md");
            IWebElement txtpassword = driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div:nth-child(3) > input[type=password]"));
            driver.WaitForElementToBeClickable(5, txtpassword).SendKeys("ecaterina123");
            IWebElement txtconfpassword = driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div:nth-child(4) > input[type=password]"));
            driver.WaitForElementToBeClickable(5, txtconfpassword).SendKeys("ecaterina123");
            IWebElement clicksignup = driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > input[type=submit]"));
            driver.WaitForElementToBeClickable(5, clicksignup).Click();
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/index.html");
        }


        [Test]
        public void Test3Lab6()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            driver.FindElement(By.LinkText("Women's wear")).Click();
            driver.FindElement(By.LinkText("Women Clothing")).Click();
            driver.FindElement(By.LinkText("Black Basic Shorts")).Click();
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/black-basic-shorts.html");

        }

        [Test]
        public void Test4Lab6()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Element = driver.FindElement(By.ClassName("footer"));
            js.ExecuteScript("arguments[0].scrollIntoView();", Element);
            driver.FindElement(By.CssSelector("body > div.footer > div > div.col-md-3.footer-left > ul > li:nth-child(1) > a > div.front")).Click();
            String URL = driver.Url;
            Assert.AreEqual(URL, "facebook.com");
        }

        [Test]
        public void Test5Lab6()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            driver.FindElement(By.LinkText("Contact")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Element = driver.FindElement(By.ClassName("agile-contact-left"));
            js.ExecuteScript("arguments[0].scrollIntoView();", Element);
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div.styled-input.agile-styled-input-top > input[type=text]")).Click();
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div.styled-input.agile-styled-input-top > input[type=text]")).SendKeys("Ecaterina");
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(2) > input[type=email]")).SendKeys("ecaterina.pavlenco@ati.utm.md");
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(2) > input[type=email]")).Click();
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(3) > input[type=text]")).SendKeys("Ask about product");
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(3) > input[type=text]")).Click();
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(4) > textarea")).SendKeys("What is the matter of the pink jacket ? ");
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(4) > textarea")).Click();
            driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > input[type=submit]")).Click();
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/clothes-jeans.html");
        }

        [Test]
        public void Test6Lab6()
        {
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            driver.FindElement(By.LinkText("Sign Up")).Click();
           IWebElement signModal = driver.WaitForElementToAppear(10, By.Id("myModal"));
           IWebElement socialmediabtn = driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > ul > li:nth-child(1) > a > div.front > i"));
            driver.WaitForElementToBeClickable(5, socialmediabtn).Click();
            String URL = driver.Url;
            Assert.AreEqual(URL, "facebook.com");
        }

    }
}

