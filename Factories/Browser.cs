using InvoiceCloudSeleniumTest.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using InvoiceCloudSeleniumTest.Common;

namespace InvoiceCloudSeleniumTest.Factories
{
    internal class Browser 
    {
        public IWebDriver _webDriver;

        public Browser()
        {
            _webDriver = WebDriverFactory.CreateWebDriverInstance(EBrowserType.Chrome_Headless, 10000);
        }

        public AddRemoveElementsPage GetAddRemoveElementsPage()
        {
            var page =  new AddRemoveElementsPage(_webDriver);
            PageFactory.InitElements(_webDriver, page);

            _webDriver.Navigate().GoToUrl(AddRemoveElementsPage.HOME_PAGE);


            return page;
        }

        public void Quit()
        {
            _webDriver?.Quit();

        }

      
    }
}
