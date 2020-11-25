using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Lab7CS.Page_and_Functionality;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab7CS.Steps
{
    [Binding]
    public sealed class Test1StepDefinition
    {



        PTest1 ptest1 = null;

        [Given(@"Open Google Chrome Browser")]
        public void GivenOpenGoogleChromeBrowser()
        {
            var htmlReporter = new ExtentHtmlReporter(@"D:\lab\Lab5- CS\Lab 7\Lab7CS\Lab7CS\ExtendReport.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            var feautureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            var scenario = feautureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            extent.Flush();
            ptest1 = new PTest1();
            ptest1.Step1();

        }

        [Given(@"Maximize Window")]
        public void GivenMaximizeWindow()
        {
            ptest1.Step2();
        }

        [When(@"Put in the URL box link")]
        public void WhenPutInTheURLBoxLink()
        {
            ptest1.Step3();
        }

        [Then(@"Google Chrome are working")]
        public void ThenGoogleChromeAreWorking()
        {
            ptest1.ControlResult();
        }

    }
}
