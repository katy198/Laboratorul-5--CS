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
    public sealed class Test3StepDefinition
    {

        PTest3 pTest3 = null;


        [Given(@"Open Google Chrome browser")]
        public void GivenOpenGoogleChromeBrowser()
        {
            var htmlReporter = new ExtentHtmlReporter(@"D:\lab\Lab5- CS\Lab 7\Lab7CS\Lab7CS\ExtendReport1.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            var feautureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            var scenario = feautureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            extent.Flush();
            pTest3 = new PTest3();
            pTest3.Step1();
        }

        [Given(@"Entered nothing")]
        public void GivenEnteredNothing()
        {
            pTest3.Step2();
        }

        [When(@"Search button")]
        public void WhenSearchButton()
        {
            pTest3.Step3();
        }

        [Then(@"Nothing should occur")]
        public void ThenNothingShouldOccur()
        {
            pTest3.ControlResult();
        }

    }
}
