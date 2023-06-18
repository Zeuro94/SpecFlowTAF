using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowTAF.Implementation;
using SpecFlowTAF.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTAF.StepDefinitions
{
    [Binding]
    public class AlertPageFeatureStepDefinitions : BaseSteps
        
    {
        readonly AlertPage alertPage;
       

        public AlertPageFeatureStepDefinitions()
        {
           
            alertPage = new AlertPage(driver);
        }

        [Given(@"User navigate to webpage ""([^""]*)""")]
        public void GivenUserNavigateToWebpage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"User trigger alert")]
        public void WhenUserClickOnAlert()
        {
            alertPage.clickOnAlertBox();
        }

        [Then(@"Alert is present")]
        public void ThenAlertIsPresent()
        {
            Assert.IsTrue(alertPage.IsAlertPresent());
            elementControl.OkAlert();
            driver.Quit();
        }

        [When(@"User not trigger alert")]
        public void WhenUserNotTriggerAlert()
        {
            Console.WriteLine("User don't click on anything");
        }

        [Then(@"Alert is not present")]
        public void ThenAlertIsNotPresent()
        {
            Assert.IsFalse(alertPage.IsAlertPresent());
            driver.Quit();
        }

    }
}

