using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;

namespace OrangeHRMTests.PageObjects.Elements
{
    public static class TopbarMenu
    {
        private static string TopbarMenuButtonByName = "//nav[@aria-label='Topbar Menu']//*[contains(text(),'{0}')]";

        public static void ClickTopbarMenuButtonByName(string value) => new MyWebElement(By.XPath(string.Format(TopbarMenuButtonByName, value))).Click();

        public static string ReturnTopbarMenuElementTextByName(string value) => new MyWebElement(By.XPath(string.Format(TopbarMenuButtonByName, value))).Text;
    }
}
