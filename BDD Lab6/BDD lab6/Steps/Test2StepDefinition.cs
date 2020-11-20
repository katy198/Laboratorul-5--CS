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
    public sealed class Test2StepDefinition
    {

        SearchPage searchPage = null;


        //Step Definitions
        [Given(@"User is on Main page")]
        public void GivenUserIsOnMainPage()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\1\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            searchPage = new SearchPage(driver);


        }

        [Given(@"User enter the following detail on search bar")]
        public void GivenUserEnterTheFollowingDetailOnSearchBar(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            searchPage.ProductNameInsert((string)data.Product);
        }

        [When(@"User press enter")]
        public void WhenUserPressEnter()
        {
            searchPage.SearchButton();
        }

        [Then(@"User can se entered product")]
        public void ThenUserCanSeEnteredProduct()
        {
           searchPage.CompareResult();
        }

    }
}
