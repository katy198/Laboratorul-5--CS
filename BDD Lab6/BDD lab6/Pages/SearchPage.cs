using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_lab6.Pages
{
    class SearchPage
    {
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver { get; }

        public IWebElement searchElement => driver.FindElement(By.Name("search"));

        public void ProductNameInsert( string product)
        {
            searchElement.SendKeys(product);
                
        }


        public void SearchButton() => searchElement.SendKeys(Keys.Enter);

        public void CompareResult()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/clothes-jeans.html");
        }
    }
}
