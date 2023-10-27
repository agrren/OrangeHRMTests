using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;
using OrangeHRMTests.PageObjects.Elements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class PIMPage : BasePage
    {
        private MyWebElement FirstTextBox = new MyWebElement(By.XPath("//div[@class='--name-grouped-field']/div[1]//input"));
        private MyWebElement MiddleTextBox = new MyWebElement(By.XPath("//div[@class='--name-grouped-field']/div[2]//input"));
        private MyWebElement LastTextBox = new MyWebElement(By.XPath("//div[@class='--name-grouped-field']/div[3]//input"));
        private MyWebElement SaveOneButton = new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyWebElement SaveTwoButton = new MyWebElement(By.XPath("//form[@class='oxd-form']/div[5]/button"));
        private MyWebElement CreatedEmployeeListFirstPosition = new MyWebElement(By.XPath("//div[@role='listbox']/div[1]/span"));

        public string FullUserName = "//input[@placeholder='{0}']";

        public string ReturnNameFirstPart() => FirstTextBox.GetAttribute("placeholder");

        public string ReturnNameMiddlePart() => MiddleTextBox.GetAttribute("placeholder");

        public string ReturnNameLastPart() => LastTextBox.GetAttribute("placeholder");

        public string ReturnFirstAndMiddleNameTextResult() => Tables.GetCellText("First (& Middle) Name");

        public string ReturnLastNameTextResult() => Tables.GetCellText("Last Name");

        public void EnterUserName(string field, string value) => new MyWebElement(By.XPath(string.Format(FullUserName, field))).SendKeys(value);

        public void ClickEmployeeListButton() => TopbarMenu.ClickTopbarMenuButtonByName("Employee List");

        public void ClickCreatedEmployeeFirstPosition() => CreatedEmployeeListFirstPosition.Click();

        public void EnterFirstName() => EnterUserName(ReturnNameFirstPart(),"111");

        public void EnterMiddleName() => EnterUserName(ReturnNameMiddlePart(), "222");

        public void EnterLastName() => EnterUserName(ReturnNameLastPart(), "333");

        public void EnterCreatedEmployeeNameTextBoxElement() => Fields.EnterValueInInputTextField("Employee Name", "111 222");

        public void EnterUnvalidEmployeeNameTextBoxElement() => Fields.EnterValueInInputTextField("Employee Name", "123456");

        public void ClickSaveOneButton() => SaveOneButton.Click();

        public void ClickSaveTwoButton() => SaveTwoButton.Click();

        public void ClearEmployeeNameTextBoxElement() => Fields.EnterValueInInputTextField("Employee Name", Keys.Control + "a" + Keys.Delete);
    }
}
