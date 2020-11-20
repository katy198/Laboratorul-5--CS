using BDD_lab6.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace BDD_lab6.Steps
{
    [Binding]
    public sealed class Test1StepDefinition
    {


        SignUpPage signUpPage = null;


        //Step Definition
        [Given(@"User is on main page")]
        public void GivenUserIsOnMainPage()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\1\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/index.html");
            signUpPage = new SignUpPage(driver);
        }

        [Given(@"User clicks on '(.*)' link")]
        public void GivenUserClicksOnLink(string p0)
        {
            signUpPage.OpenSignUpmenu();
        }

        [Given(@"User enter the following detail")]
        public void GivenUserEnterTheFollowingDetails(Table table)
        {

            dynamic data = table.CreateDynamicInstance();

            signUpPage.SignUpInformation((string)data.Name, (string)data.Email, (string)data.Password, (string)data.ConfirmPassword);   
        }

        [When(@"User clicks on SignUp")]
        public void WhenUserClicksOnSignUp()
        {
            signUpPage.ClickSignUpButton(); 
        }

        [Then(@"User is registered successfully")]
        public void ThenUserIsRegisteredSuccessfully()
        {
            signUpPage.CompareResult();
        }
 
    }
}
