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
    public sealed class Test4StepDefinition
    {
        PTest4 pTest4 = null;

        [Given(@"Open Chrome browser")]
        public void GivenOpenChromeBrowser()
        {
            var htmlReporter = new ExtentHtmlReporter(@"D:\lab\Lab5- CS\Lab 7\Lab7CS\Lab7CS\ExtendReport1.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            var feautureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            var scenario = feautureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            extent.Flush();
            pTest4 = new PTest4();
            pTest4.Step1();
        }

        [Given(@"Enter irrelevant text")]
        public void GivenEnterIrrelevantText()
        {
            pTest4.Step2();
        }

        [When(@"Press search button")]
        public void WhenPressSearchButton()
        {
            pTest4.Step3();
        }

        [Then(@"Link Did you mean displayed")]
        public void ThenLinkDisplayed()
        {
            pTest4.ControlResult();
        }

    }
}
