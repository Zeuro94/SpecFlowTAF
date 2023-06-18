using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTAF.Implementation
{
    public class CommonDriver
    {
        private IWebDriver Driver;

        public CommonDriver(String browserType)
        {
            if (browserType.Equals("chrome"))
            {
                Driver = BrowserManager.GetChromeDriver();
            } else if (browserType.Equals("firefox"))
            {
                Driver = BrowserManager.GetFirefoxDriver();
            } else if (browserType.Equals("edge"))
            {
                Driver = BrowserManager.GetEdgeDriver();
            } else
            {
                throw new NotFoundException("Invalid browser type" + browserType);
            }

            Driver.Manage().Window.Minimize();
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        public long setPageLoadTimer(int pageLoadTimer)
        {
            return pageLoadTimer;
        }

        public long setElementDetectionTimeout(int elementDetectionTimeout) {
            return elementDetectionTimeout;
        }

        public IWebDriver? getDriver()
        {
            return Driver;
        }
    }
}
