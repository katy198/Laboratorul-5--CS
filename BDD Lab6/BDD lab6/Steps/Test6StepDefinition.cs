using BDD_lab6.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_lab6.Steps
{
    [Binding]
    public sealed class Test6StepDefinition
    {

        SignUpSocialMedia signUpSocialMedia = null;
        [Given(@"User acces main page")]
        public void GivenUserAccesMainPage()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\1\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            signUpSocialMedia = new SignUpSocialMedia(driver);
        }

        [Given(@"User link Sign Up button")]
        public void GivenUserLinkSignUpButton()
        {
            signUpSocialMedia.SignClick();
        }

        [When(@"User acces Facebook button for register")]
        public void WhenUserAccesFacebookButtonForRegister()
        {
            signUpSocialMedia.SignSocialMediaBTN();
        }

        [Then(@"User are successfulyy register from Facebook page")]
        public void ThenUserAreSuccessfulyyRegisterFromFacebookPage()
        {
            signUpSocialMedia.CompareResult();
        }

    }

}
