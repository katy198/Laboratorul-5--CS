using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Lab7CS.Page_and_Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab7CS.Steps
{
    [Binding]
    public sealed class Test2StepDefinition
    {
        PTest2 pTest2 = null;

        [Given(@"Open Browser")]
        public void GivenOpenBrowser()
        {
            var htmlReporter = new ExtentHtmlReporter(@"D:\lab\Lab5- CS\Lab 7\Lab7CS\Lab7CS\ExtendReport1.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            var feautureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            var scenario = feautureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            extent.Flush();
            pTest2 = new PTest2();
            pTest2.Step1();
        }

        [Given(@"Enter some text")]
        public void GivenEnterSomeText()
        {
            pTest2.Step2();
        }

        [Given(@"Press Enter")]
        public void GivenPressEnter()
        {
            pTest2.Step3();
        }

        [When(@"Count results")]
        public void WhenCountResults()
        {
            pTest2.Step4();
        }

        [Then(@"Entered in console number of results")]
        public void ThenEnteredInConsoleNumberOfResults()
        {
            pTest2.Step5();
        }

    }
}
