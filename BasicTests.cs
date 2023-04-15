using InvoiceCloudSeleniumTest.Factories;

namespace InvoiceCloudSeleniumTest
{
    public class Tests
    {
        private Browser _browser; 

        [SetUp]
        public void Setup()
        {
            _browser = new Browser();
        }
         
         
        [TestCase(1, TestName = "Just One Item")]
        [TestCase(5, TestName = "Five Items")]
        [TestCase(20, TestName = "Twenty Items")]
        [TestCase(1000, TestName = "A lot of items (1000)")]
        public void AddButtons(int numButtons)
        {
            var page = _browser.GetAddRemoveElementsPage();

            for(int i = 0; i < numButtons; i++)
            {
                page.ClickAddElementButton();
            }

            var elements = page.Elements;
            Assert.IsNotNull(elements, "Couldn't find elements items.");

            Assert.That(elements, Is.Not.Null);
            Assert.That(numButtons, Is.EqualTo(elements.Count));
        }

         
        [TearDown]
        public void TearDown()
        {
            _browser.Quit();
        }
    }
}