using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;

namespace OrangeHRMTests.PageObjects.Elements
{
    public static class Fields
    {
        public static string XPathInputTextFieldByName = "//label[text()='{0}']//ancestor::div[1]//following-sibling::div[1]//input";

        public static string XPathFirstPosition = "//label[text()='{0}']//ancestor::div[1]//following-sibling::div[1]//div[@role='listbox']/div[1]/span";

        public static void EnterValueInInputTextField (string field, string value) => new MyWebElement(By.XPath(string.Format(XPathInputTextFieldByName, field))).SendKeys(value);

        public static void ClickFirstPosition(string field) => new MyWebElement(By.XPath(string.Format(XPathInputTextFieldByName, field))).Click();

        public static string ReturnValueOfTextFieldByName(string field) => new MyWebElement(By.XPath(string.Format(XPathInputTextFieldByName, field))).Text;
    }
}
