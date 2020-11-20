using BDD_lab6.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD_lab6.Steps
{
    [Binding]
    public sealed class Test5StepDefinition
    {
        ContactPage contactPage = null;

        [Given(@"User acces Main Page")]
        public void GivenUserAccesMainPage()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\1\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");

            contactPage = new ContactPage(driver);
        }

        [Given(@"User acces Contact link on home bar")]
        public void GivenUserAccesContactLinkOnHomeBar()
        {
            contactPage.ContactClick();
        }

        [Given(@"User scroll to the Contact Form")]
        public void GivenUserScrollToTheContactForm()
        {
            contactPage.Scroll();
        }

        [Given(@"User fill needed information")]
        public void GivenUserFillNeededInformation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            contactPage.FillInformation((string)data.Name, (string)data.Email, (string)data.Subject, (string)data.Message);
        }

        [When(@"User acces button Send")]
        public void WhenUserAccesButtonSend()
        {
            contactPage.Send();
        }

        [Then(@"Message is successfully send")]
        public void ThenMessageIsSuccessfullySend()
        {
            contactPage.CompareResult();
        }

    }
}
