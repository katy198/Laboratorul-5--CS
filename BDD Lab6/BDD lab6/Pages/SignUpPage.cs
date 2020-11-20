using BDD_lab6.Extension;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_lab6.Pages
{   class SignUpPage
    {
        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebDriver driver { get; }

        public IWebElement lnkSignUp => driver.FindElement(By.LinkText("Sign Up"));

        public IWebElement txtName => driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div.styled-input.agile-styled-input-top > input[type=text]"));

        public IWebElement txtEmail => driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div:nth-child(2) > input[type=email]"));

        public IWebElement txtPassword => driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div:nth-child(3) > input[type=password]"));

        public IWebElement txtConfPassword => driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > div:nth-child(4) > input[type=password]"));

        public IWebElement clicksignup => driver.FindElement(By.CssSelector("#myModal2 > div > div > div.modal-body.modal-body-sub_agile > div.col-md-8.modal_body_left.modal_body_left1 > form > input[type=submit]"));


        public void OpenSignUpmenu()
        {
            lnkSignUp.Click();
            IWebElement signModal = driver.WaitForElementToAppear(10, By.Id("myModal"));
        }
        public void SignUpInformation (string name, string email , string password , string confirmPassword)
        {
            driver.WaitForElementToBeClickable(5, txtName).SendKeys(name);
            driver.WaitForElementToBeClickable(5, txtEmail).SendKeys(email);
            driver.WaitForElementToBeClickable(5, txtPassword).SendKeys(password);
            driver.WaitForElementToBeClickable(5, txtConfPassword).SendKeys(confirmPassword);

        }

        public void ClickSignUpButton()
        {
            driver.WaitForElementToBeClickable(5, clicksignup).Click();
        }
        public void CompareResult()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://loving-hermann-e2094b.netlify.app/index.html");
        }

    }
}
