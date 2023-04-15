using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceCloudSeleniumTest.Common;

namespace InvoiceCloudSeleniumTest.Factories
{


    internal static class WebDriverFactory
    {

        public static IWebDriver CreateWebDriverInstance(EBrowserType browserType, int cmdTimeOutInMillis)
        {
            IWebDriver driver = null;

            if (driver != null)
                return driver;

            ChromeOptions chromeOptions;
            switch (browserType)
            {
                case EBrowserType.Chrome_Headless:
                    chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--headless");
                    driver = CreateChromeDriver(chromeOptions, cmdTimeOutInMillis);
                    break;
                case EBrowserType.Chrome:
                default:
                    chromeOptions = new ChromeOptions();
                    driver = CreateChromeDriver(chromeOptions, cmdTimeOutInMillis);
                    break;

            }

            SetImplicitWait(driver, 10);
            return driver;
        }

        private static void SetImplicitWait(IWebDriver driver,  int timeOutInSeconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeOutInSeconds);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeOutInSeconds);
        }

        private static IWebDriver CreateChromeDriver(ChromeOptions options, int cmdTimeOutInMillis)
        {
            options.AddArgument("--no-sandbox");
            var timeOut = TimeSpan.FromMilliseconds(cmdTimeOutInMillis);
            return
                new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, timeOut);

        }
    }
}
