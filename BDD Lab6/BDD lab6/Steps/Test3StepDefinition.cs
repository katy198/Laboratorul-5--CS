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
    public sealed class Test3StepDefinition
    {

        ProductPage productPage = null;


        [Given(@"User is on main Page")]
        public void GivenUserIsOnMainPage()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\1\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            productPage = new ProductPage(driver);

        }

        [Given(@"User click Women's wear compartiment")]
        public void GivenUserClickWomenSWearCompartiment()
        {
            productPage.WomWearBtnChoose();
        }

        [Given(@"User choose Women Clothing part")]
        public void GivenUserChooseWomenClothingPart()
        {
            productPage.WomClothBtnChoose();
        }

        [When(@"User choose Black Basic Shorts Product")]
        public void WhenUserChooseBlackBasicShortsProduct()
        {
            productPage.ProductChoose();
        }

        [Then(@"Black Basic Shorts Product is open")]
        public void ThenBlackBasicShortsProductIsOpen()
        {
            productPage.CompareResult();
        }

    }
}
