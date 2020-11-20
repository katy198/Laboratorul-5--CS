using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_lab6.Pages
{
    class ContactPage
    {
        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver { get; }


        public IWebElement contactbtn => driver.FindElement(By.LinkText("Contact"));

        public void ContactClick() => contactbtn.Click();

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Element = driver.FindElement(By.ClassName("agile-contact-left"));
            js.ExecuteScript("arguments[0].scrollIntoView();", Element);
        }

        public IWebElement txtName => driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div.styled-input.agile-styled-input-top > input[type=text]"));
        public IWebElement txtEmail => driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(2) > input[type=email]"));

        public IWebElement txtSubject => driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(3) > input[type=text]"));

        public IWebElement txtMessage => driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > div:nth-child(4) > textarea"));

        public void FillInformation(string name, string email, string subject, string message)
        {
            txtName.SendKeys(name);
            txtEmail.SendKeys(email);
            txtSubject.SendKeys(subject);
            txtMessage.SendKeys(message);

        }

        public IWebElement sendBtn => driver.FindElement(By.CssSelector("body > div:nth-child(9) > div > div > div.agile-contact-left > div.col-md-6.contact-form > form > input[type=submit]"));


        public void Send() => sendBtn.Click();

        public void CompareResult()
        {

            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/contact.html");
        
        }
    
    }
}
