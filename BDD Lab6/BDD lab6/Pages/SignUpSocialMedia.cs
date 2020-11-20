using BDD_lab6.Extension;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_lab6.Pages
{
    class SignUpSocialMedia
    {
        public SignUpSocialMedia(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver { get; }
        private IWebElement signModal;

        public IWebElement signbtn => driver.FindElement(By.LinkText("Sign Up"));

        public IWebElement socialmediabtn => driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > ul > li:nth-child(1) > a > div.front > i"));

        public void SignClick()
        {

            signbtn.Click();
            signModal = driver.WaitForElementToAppear(10, By.Id("myModal"));
        }
        public void SignSocialMediaBTN()
        {
            driver.WaitForElementToBeClickable(5, socialmediabtn).Click();
        }

        public void CompareResult()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "facebook.com");
        }
    }
}
