using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceCloudSeleniumTest.PageObjects
{
    internal partial class AddRemoveElementsPage
    {

        //[FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div/button")]
        [FindsBy(How = How.TagName, Using = "Button")]
        internal IWebElement AddElementButton;

        [FindsBy(How = How.ClassName, Using = "added-manually")]
        internal IList<IWebElement> Elements;

    }
}
