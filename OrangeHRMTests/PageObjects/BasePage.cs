using OpenQA.Selenium;
using OrangeHRMTests.Common.Drivers;
using OrangeHRMTests.Common.WebElements;
using OrangeHRMTests.Data;
using OrangeHRMTests.PageObjects.Modules;
using OrangeHRMTests.PageObjects.Buttons;

namespace OrangeHRMTests.PageObjects
{
    public class BasePage : WebDriverFactory
    {
        //private MyWebElement AddButton = new MyWebElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--secondary']"));
        //private MyWebElement SaveButton = new MyWebElement(By.XPath("//button[@type='submit']"));
        //private MyWebElement ConfirmDeletionButton = new MyWebElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--label-danger orangehrm-button-margin']"));

        private MyWebElement CreatedEmployeeListFirstPosition = new MyWebElement(By.XPath("//div[@role='listbox']/div[1]/span"));
        private MyWebElement EmployeeNameHintedTextBoxElement = new MyWebElement(By.XPath("//label[@class='oxd-label'][text()='Employee Name']//ancestor::div[1]//following-sibling::div[1]//input"));
        //private MyWebElement SearchButton = new MyWebElement(By.XPath("//button[@type='submit'][text()=' Search ']"));
        private MyWebElement TrashButton = new MyWebElement(By.XPath("//i[@class='oxd-icon bi-trash']"));
        private MyWebElement YesDeleteButton = new MyWebElement(By.XPath("//i[@class='oxd-icon bi-trash oxd-button-icon']"));

        public const string XPathToTableCell = "(//div[@class='oxd-table-card']//div[@role='row'])[1]//div[@role='cell'][count(//div[text()='{0}']//preceding-sibling::div)+1]";

        public string GetCellText(string value)
        {
            var cellXPath = string.Format(XPathToTableCell, value);
            var element = new MyWebElement(By.XPath(cellXPath));
            var text = element.Text;

            return text;
        }

        public void DeleteCreatedUser()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToPIMPage();
            EmployeeNameHintedTextBoxElement.SendKeys("111 222");
            CreatedEmployeeListFirstPosition.Click();
            PageObjects.Buttons.Buttons.ClickSearchButton();
            TrashButton.Click();
            YesDeleteButton.Click();
        }

        public LeftMenuNavigationPanel LeftMenuNavigationPanel => new LeftMenuNavigationPanel();

        public void GoToLoginPage() => WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.PageUrl);

        //public void ClickAddButton() => AddButton.Click();

        //public void ClickSaveButton() => SaveButton.Click();

        //public void ClickSearchButton() => SearchButton.Click();

        //public void ClickConfirmDeletionButton() => ConfirmDeletionButton.Click();
    }
}
