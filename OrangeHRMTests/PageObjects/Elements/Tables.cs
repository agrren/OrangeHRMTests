using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMTests.PageObjects.Elements
{
    public static class Tables
    {
        public static string XPathToTableCell = "(//div[@class='oxd-table-card']//div[@role='row'])[1]//div[@role='cell'][count(//div[text()='{0}']//preceding-sibling::div)+1]";

        public static string GetCellText(string value) => new MyWebElement(By.XPath(string.Format(XPathToTableCell, value))).Text;
    }
}
