using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class PIMPage : BasePage
    {
        private MyWebElement FirstTextBox = new MyWebElement(By.XPath("//div[@class='--name-grouped-field']/div[1]//input"));
        private MyWebElement MiddleTextBox = new MyWebElement(By.XPath("//div[@class='--name-grouped-field']/div[2]//input"));
        private MyWebElement LastTextBox = new MyWebElement(By.XPath("//div[@class='--name-grouped-field']/div[3]//input"));
        private MyWebElement SaveOneButton = new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyWebElement AddedFirstAndMiddleNameTextBox = new MyWebElement(By.XPath("//div[@class='oxd-table-body']/div[1]/div[1]/div[3]"));
        private MyWebElement AddedLastNameTextBox = new MyWebElement(By.XPath("//div[@class='oxd-table-body']/div[1]/div[1]/div[4]"));
        private MyWebElement SaveTwoButton = new MyWebElement(By.XPath("//form[@class='oxd-form']/div[5]/button"));
        private MyWebElement EmployeeListButton = new MyWebElement(By.XPath("//a[contains(text(), 'Employee List')]"));
        private MyWebElement EmployeeNameHintedTextBoxElement = new MyWebElement(By.XPath("//label[@class='oxd-label'][text()='Employee Name']//ancestor::div[1]//following-sibling::div[1]//input"));

        public string FullUserName = "//input[@placeholder='{0}']";

        public void EnterUserName(string field, string value)
        {
            {
                var element = new MyWebElement(By.XPath(string.Format(FullUserName, field)));
                element.SendKeys(value);
            }
        }

        public void ClickEmployeeListButton() => EmployeeListButton.Click();

        public void EnterFirstName() => EnterUserName(ReturnNameFirstPart(),"111");

        public void EnterMiddleName() => EnterUserName(ReturnNameMiddlePart(), "222");

        public void EnterLastName() => EnterUserName(ReturnNameLastPart(), "333");

        public void EnterEmployeeNameHintedTextBoxElement() => EmployeeNameHintedTextBoxElement.SendKeys("111 222");

        public void ClickSaveOneButton() => SaveOneButton.Click();

        public void ClickSaveTwoButton() => SaveTwoButton.Click();

        public string ReturnNameFirstPart() => FirstTextBox.GetAttribute("placeholder");

        public string ReturnNameMiddlePart() => MiddleTextBox.GetAttribute("placeholder");

        public string ReturnNameLastPart() => LastTextBox.GetAttribute("placeholder");

        public string ReturnFirstAndMiddleNameTextResult() => AddedFirstAndMiddleNameTextBox.Text;

        public string ReturnLastNameTextResult() => AddedLastNameTextBox.Text;
    }
}
