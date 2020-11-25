using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab7CS
{
    public class Hook
    {
        private static ExtentTest feautureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"D:\lab\Lab5- CS\Lab 7\Lab7CS\Lab7CS\ExtendReport1.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }


        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }

        [BeforeFeature]
        public static void Beforefeature()
        {
            feautureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
           
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            scenario = feautureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterStep]
        public static void InserReportingSteps()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
        }


    }
}
