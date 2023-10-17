using OpenQA.Selenium;
using OrangeHRMTests.Common.Extensions.ExtensionMethods;
using OrangeHRMTests.Common.WebElements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class AdminUserManagement : BasePage
    {
        private MyWebElement UserNameTextBox = new MyWebElement(By.XPath("//div[@class='oxd-grid-4 orangehrm-full-width-grid']//input[1]"));
        private MyWebElement UserRoleDropdownArrow = new MyWebElement(By.XPath("//div[@class='oxd-grid-4 orangehrm-full-width-grid']/div[2]//i"));
        private MyWebElement UserStatusDropdownArrow = new MyWebElement(By.XPath("//div[@class='oxd-grid-4 orangehrm-full-width-grid']/div[4]//i"));
        private MyWebElement EmployeeNameTextBox = new MyWebElement(By.XPath("//div[@class='oxd-grid-4 orangehrm-full-width-grid']/div[3]//input[1]"));

        public void EnterUserName() => UserNameTextBox.SendKeys(GetCellText("Username"));

        public void ClickUserRoleDropdownArrow() => Buttons.Buttons.ClickDropDownListArrowButtonByName("User Role");

        public void ClickUserStatusDropdownArrow() => Buttons.Buttons.ClickDropDownListArrowButtonByName("Status");

        public void EnterEmployeeName() => EmployeeNameTextBox.SendKeys(GetCellText("Employee Name"));

        public void ChooseUserRole() => DropdownExtension.ClickDropdownList(GetCellText("User Role"));

        public void ChooseUserStatus() => DropdownExtension.ClickDropdownList(GetCellText("Status"));
    }
}
