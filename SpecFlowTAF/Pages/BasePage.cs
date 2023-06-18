using OpenQA.Selenium;
using SpecFlowTAF.Implementation;
using SeleniumExtras.PageObjects;


namespace SpecFlowTAF.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver? Driver;
        protected readonly ElementControl? elementControl;

        public BasePage(IWebDriver Driver)
        {
            this.Driver = Driver;
            elementControl = new ElementControl(Driver);
            PageFactory.InitElements(Driver, this);
        }
    }
}
