using InvoiceCloudSeleniumTest.Factories;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceCloudSeleniumTest.PageObjects
{
    internal partial class AddRemoveElementsPage
    {
        public static readonly string HOME_PAGE = "https://the-internet.herokuapp.com/add_remove_elements/";
        private IWebDriver webDriver;

        public AddRemoveElementsPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void ClickAddElementButton()
        {
            this.AddElementButton.Click();
        }

        

    }

}
