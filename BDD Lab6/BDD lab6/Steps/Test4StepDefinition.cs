using BDD_lab6.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_lab6.Steps
{
    [Binding]
    public sealed class Test4StepDefinition
    {

        SocialMediaPage socialMediaPage = null;

    
        [Given(@"User is on Main Page")]
        public void GivenUserIsOnMainPage()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\1\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            socialMediaPage = new SocialMediaPage(driver);
        }

        [Given(@"User scroll to the footer")]
        public void GivenUserScrollToTheFooter()
        {
            socialMediaPage.Scroll();
        }

        [When(@"User acces Facebook social media")]
        public void WhenUserAccesFacebookSocialMedia()
        {
            socialMediaPage.AccesMedia();
        }

        [Then(@"User is redirected to store's page in Facebook")]
        public void ThenUserIsRedirectedToStoreSPageInFacebook()
        {
            socialMediaPage.CompareResult();
        }

    }
}
