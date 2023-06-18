using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTAF.Implementation
{
    public class ElementControl
    {
        public IWebDriver driver;

        public ElementControl(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnElement(IWebElement element)
        {
            element.Click();
        }

        public void Clear(IWebElement element)
        {
            element.Clear();
        }

        public string GetTextFromElement(IWebElement element)
        {
            return element.Text;
        }

        public void SetTextForElement(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public bool IsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }

        public bool IsEnabled(IWebElement element)
        {
            return element.Enabled;
        }

        public string GetTextFromAlert()
        {
            return driver.SwitchTo().Alert().Text;
        }

        public void OkAlert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void CancelAlert()
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public string GetTitleOfPage()
        {
            return driver.Title;
        }
    }
}
