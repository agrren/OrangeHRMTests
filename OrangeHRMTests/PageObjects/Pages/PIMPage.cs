﻿using OpenQA.Selenium;
using OrangeHRMTests.Common.Extensions;
using OrangeHRMTests.Common.WebElements;
using OrangeHRMTests.PageObjects.Elements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class PIMPage : BasePage
    {
        private MyWebElement SaveOneButton = new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyWebElement SaveTwoButton = new MyWebElement(By.XPath("//form[@class='oxd-form']/div[5]/button"));
        private MyWebElement CreatedEmployeeListFirstPosition = new MyWebElement(By.XPath("//div[@role='listbox']/div[1]/span"));
        
        public string FullUserName = "//label[text()='Employee Full Name']//ancestor::div[1]//following-sibling::div[1]//input[@name='{0}']";
        
        public string ReturnFirstAndMiddleNameTextResult() => Tables.GetCellText("First (& Middle) Name");

        public string ReturnLastNameTextResult() => Tables.GetCellText("Last Name");

        public void EnterUserName(string field, string value) => new MyWebElement(By.XPath(string.Format(FullUserName, field))).SendKeys(value);

        public void ClickEmployeeListButton() => TopbarMenu.ClickTopbarMenuButtonByName("Employee List");

        public void ClickCreatedEmployeeFirstPosition() => CreatedEmployeeListFirstPosition.Click();

        public void ClickUserName(string field) => new MyWebElement(By.XPath(string.Format(FullUserName, field))).Click();

        public void ClearFullUserName()
        {
            ClickUserName("firstName");
            EnterUserName("firstName", Keys.Control + "a" + Keys.Delete);
            ClickUserName("middleName");
            EnterUserName("middleName", Keys.Control + "a" + Keys.Delete);
            ClickUserName("lastName");
            EnterUserName("lastName", Keys.Control + "a" + Keys.Delete);
        }

        public void EnterFullUserName()
        {
            EnterUserName("firstName", "111");
            EnterUserName("middleName", "222");
            EnterUserName("lastName", "333");
        }

        public void EnterCreatedEmployeeNameTextBoxElement() => Fields.EnterValueInInputTextField("Employee Name", "111 222");

        public void EnterUnvalidEmployeeNameTextBoxElement() => Fields.EnterValueInInputTextField("Employee Name", "123456");

        public void ClickSaveOneButton() => SaveOneButton.Click();

        public void ClickSaveTwoButton() => SaveTwoButton.Click();

        public void ClearEmployeeNameTextBoxElement() => Fields.EnterValueInInputTextField("Employee Name", Keys.Control + "a" + Keys.Delete);
    }
}
