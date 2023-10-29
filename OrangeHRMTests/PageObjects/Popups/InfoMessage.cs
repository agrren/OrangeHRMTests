using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMTests.PageObjects.Popups
{
    public class InfoMessage : BasePage
    {
        private MyWebElement InfoMessageText = new MyWebElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-text--toast-message oxd-toast-content-text']"));

        public string ReturnInfoMessageTextResult() => InfoMessageText.Text;
    }
}
