using OpenQA.Selenium;
using OrangeHRMTests.Common.Drivers;
using OrangeHRMTests.Common.Extensions;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRMTests.Common.WebElements
{
    public class MyWebElement : IWebElement
    {
        protected By By { get; set; }

        protected IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenExist(By);

        public string TagName => WebElement.TagName;

        public string Text => WebElement.Text;

        public bool Enabled => WebElement.Enabled;

        public bool Selected => WebElement.Selected;

        public Point Location => WebElement.Location;

        public Size Size => WebElement.Size;

        public bool Displayed => WebElement.Displayed;

        public MyWebElement(By by)
        {
            By = by;
        }

        public void Clear()
        {
            Waiter();
            WebElement.Clear();
        }//=> WebElement.Clear();

        public void SendKeys(string text) 
        {
            Waiter();
            WebElement.SendKeys(text);
        }//=> WebElement.SendKeys(text);

        public void Submit() => WebElement.Submit();

        public void Click()
        {
            try
            {
                Waiter();
                WebElement.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ScrollIntoView();
                Waiter();
                WebElement.Click();
            }
        }

        public string GetAttribute(string attributeName) => WebElement.GetAttribute(attributeName);

        public string GetDomAttribute(string attributeName) => WebElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName) => WebElement.GetDomProperty(propertyName);

        public string GetCssValue(string propertyName) => WebElement.GetCssValue(propertyName);

        public ISearchContext GetShadowRoot() => WebElement.GetShadowRoot();

        public IWebElement FindElement(By by) => WebElement.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => WebElement.FindElements(by);

        public void ScrollIntoView() => WebDriverFactory.JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView();", WebElement);

        public string GetValueOfClassAtrubute() => GetAttribute("class");

        public static WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromMilliseconds(5000));
        public static void Waiter() => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='oxd-form-loader']")));

        public static IWebElement FindElementByXPathId(string value)
        {
            string xPath = string.Format("//*[@id='{0}']", value);
            var element = WebDriverFactory.Driver.GetWebDriverWait().Until(drv => drv.FindElement(By.XPath(xPath)));

            return element;
        }

        public static IWebElement FindElementByXPath(string value)
        {
            var element = WebDriverFactory.Driver.GetWebDriverWait().Until(drv => drv.FindElement(By.XPath(value)));

            return element;
        }
    }
}