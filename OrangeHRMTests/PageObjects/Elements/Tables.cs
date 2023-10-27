using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;

namespace OrangeHRMTests.PageObjects.Elements
{
    public static class Tables
    {
        public static string XPathToTableCell = "(//div[@class='oxd-table-card']//div[@role='row'])[1]//div[@role='cell'][count(//div[text()='{0}']//preceding-sibling::div)+1]";
        private static MyWebElement PencilEditButton = new MyWebElement(By.XPath("(//div[@class='oxd-table-card']//div[@role='row'])[1]//div[@role='cell'][count(//div[text()='Actions']//preceding-sibling::div)+1]//i[@class='oxd-icon bi-pencil-fill']"));
        private static MyWebElement TrashButton = new MyWebElement(By.XPath("(//div[@class='oxd-table-card']//div[@role='row'])[1]//div[@role='cell'][count(//div[text()='Actions']//preceding-sibling::div)+1]//i[@class='oxd-icon bi-trash']"));

        public static string GetCellText(string value) => new MyWebElement(By.XPath(string.Format(XPathToTableCell, value))).Text;

        public static void ClickPencilEditButton() => PencilEditButton.Click();

        public static void ClickTrashButton() => TrashButton.Click();
    }
}
