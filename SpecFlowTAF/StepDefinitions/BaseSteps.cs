using OpenQA.Selenium;
using SpecFlowTAF.Implementation;
using SpecFlowTAF.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTAF.StepDefinitions
{
    public class BaseSteps
    {
        public ElementControl elementControl;
        public IWebDriver driver;
        public CommonDriver commonDriver;

        public BaseSteps()
        {

            commonDriver = new CommonDriver("chrome");
            driver = commonDriver.getDriver();
            elementControl = new ElementControl(driver);
        }

    }
}
