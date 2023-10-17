using OpenQA.Selenium;
using OrangeHRMTests.Common.Extensions.ExtensionMethods;
using OrangeHRMTests.Common.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class LeavePage : BasePage
    {
        private MyWebElement AssignLeaveButton = new MyWebElement(By.XPath("//*[contains(text(),'Assign Leave')]"));
        private MyWebElement EmployeeNameTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-autocomplete-text-input oxd-autocomplete-text-input--active']//input"));
        private MyWebElement CreatedEmployeeListFirstPosition = new MyWebElement(By.XPath("//div[@role='listbox']/div[1]/span"));
        private MyWebElement EntitlementsButton = new MyWebElement(By.XPath("//*[contains(text(),'Entitlements ')]"));
        private MyWebElement AddEntitlementsButton = new MyWebElement(By.XPath("//*[contains(text(),'Add Entitlements')]"));
        private MyWebElement EntitlementTextBoxElement = new MyWebElement(By.XPath("//*[text()='Entitlement']//ancestor::div[1]//following-sibling::div[1]/input"));
        private MyWebElement FromDateCalendarButton = new MyWebElement(By.XPath("//*[text()='From Date']//ancestor::div[1]//following-sibling::div[1]//i"));
        private MyWebElement FromDateCalendarValueButton = new MyWebElement(By.XPath("//*[text()='From Date']//ancestor::div[1]//following-sibling::div[1]//div[@class='oxd-calendar-dates-grid']//*[text()='18']"));
        private MyWebElement ToDateCalendarButton = new MyWebElement(By.XPath("//*[text()='To Date']//ancestor::div[1]//following-sibling::div[1]//i"));
        private MyWebElement ToDateCalendarValueButton = new MyWebElement(By.XPath("//*[text()='To Date']//ancestor::div[1]//following-sibling::div[1]//div[@class='oxd-calendar-dates-grid']//*[text()='25']"));
        private MyWebElement LeaveListButton = new MyWebElement(By.XPath("//*[contains(text(),'Leave List')]"));
        //private MyWebElement SearchButton = new MyWebElement(By.XPath("//button[@type='submit'][text()=' Search ']"));
        private MyWebElement LeaveTypeArrowButton = new MyWebElement(By.XPath("//div[@class='oxd-input-group__label-wrapper']//*[text()='Leave Type']//ancestor::div[1]//following-sibling::div[1]//i"));
        private MyWebElement ShowLeaveWithStatusTypeArrowButton = new MyWebElement(By.XPath("//div[@class='oxd-input-group__label-wrapper']//*[text()='Show Leave with Status']//ancestor::div[1]//following-sibling::div[1]//i"));
        private MyWebElement ConfirmButton = new MyWebElement(By.XPath("//button[@type='button'][text()=' Confirm ']"));
        private MyWebElement AssignButton = new MyWebElement(By.XPath("//button[@type='submit'][text()=' Assign ']"));
        public MyWebElement LeaveBalanceTextElement = new MyWebElement(By.XPath("//i[@class='oxd-icon bi-question-circle oxd-icon-button__icon --help']//ancestor::div[1]//following-sibling::div[1]/p[text()='10.00 Day(s)']"));
        public MyWebElement SuccessfullySavedMessageTextElement = new MyWebElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-text--toast-message oxd-toast-content-text'][text()='Successfully Saved']"));

        public string DropDownList = "//div[@class='oxd-multiselect-wrapper']/div[2]//*[contains(text(),'{0}')]";

        public void ClickDropdownList(string value)
        {
            var element = new MyWebElement(By.XPath(string.Format(DropDownList, value)));
            element.Click();
        }

        public void ClickAssignLeaveButton() => AssignLeaveButton.Click();

        public void ClickEntitlementsButton() => EntitlementsButton.Click();

        public void ClickAddEntitlementsButton() => AddEntitlementsButton.Click();

        public void ClickFromDateCalendarButton() => FromDateCalendarButton.Click();

        public void ClickFromDateCalendarValueButton() => FromDateCalendarValueButton.Click();

        public void ClickToDateCalendarButton() => ToDateCalendarButton.Click();

        public void ClickToDateCalendarValueButton() => ToDateCalendarValueButton.Click();

        public void ClickLeaveListButton() => LeaveListButton.Click();

        //public void ClickSearchButton() => SearchButton.Click();

        public void ClickLeaveTypeArrowButton() => LeaveTypeArrowButton.Click();

        public void ClickShowLeaveWithStatusTypeArrowButton() => ShowLeaveWithStatusTypeArrowButton.Click();

        public void ClickConfirmButton() => ConfirmButton.Click();

        public void ClickAssignButton() => AssignButton.Click();

        public void EnterEmployeeName() => EmployeeNameTextBoxElement.SendKeys("111");

        public void EnterEntitlement() => EntitlementTextBoxElement.SendKeys("10");

        public void ClickCreatedEmployeeFirstPosition() => CreatedEmployeeListFirstPosition.Click();

        public void ChooseLeaveType() => DropdownExtension.ClickDropdownList("CAN - Vacation");

        public void ChooseShowLeaveWithStatusType() => ClickDropdownList("Scheduled");
    }
}
