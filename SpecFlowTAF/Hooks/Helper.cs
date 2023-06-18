using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTAF.Hooks
{
    public class Helper
    {
        private IWebDriver driver;
        private ScenarioContext context;

        public Helper(ScenarioContext context)
        {
            this.context = context;
        }

        public IWebDriver Init()
        {
            return driver;
        }

        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
