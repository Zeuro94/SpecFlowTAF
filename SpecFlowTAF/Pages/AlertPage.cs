using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowTAF.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTAF.Pages
{
    public class AlertPage : BasePage
    {
        public AlertPage(IWebDriver Driver) : base(Driver) { }

        [FindsBy(How = How.Id, Using = "alertexamples")]
        public IWebElement ShowAlertBox;

        [FindsBy(How = How.Id, Using = "confirmexample")]
        public IWebElement ShowConfirmBox;

        [FindsBy(How = How.Id, Using = "promptexample")]
        public IWebElement ShowPromptBox;

        public void clickOnAlertBox()
        {
            elementControl.ClickOnElement(ShowAlertBox);
        }

        public bool IsAlertPresent()
        {
            try
            {
                Driver.SwitchTo().Alert();
                Console.WriteLine("Alert is present");
                return true;
            }
            catch (NoAlertPresentException)
            {
                Console.WriteLine("Alert is not present");
                return false;
            }
        }
    }
}
