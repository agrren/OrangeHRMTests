using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;
using OrangeHRMTests.PageObjects.Elements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class AdminPage : BasePage
    {
        private MyWebElement AdminPageHeaderElementPartOne = new MyWebElement(By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']"));
        private MyWebElement AdminPageHeaderElementPartTwo = new MyWebElement(By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-level']"));
        private MyWebElement SystemUserTableHeaderElement = new MyWebElement(By.XPath("//h5[@class='oxd-text oxd-text--h5 oxd-table-filter-title']"));
        //private MyWebElement UserManagementDropdownButton = new MyWebElement(By.XPath("//*[contains(text(),'User Management ')]"));
        private MyWebElement UsersDropdownElement = new MyWebElement(By.XPath("//ul[@class='oxd-dropdown-menu']"));
        //private MyWebElement JobDropdownButton = new MyWebElement(By.XPath("//*[contains(text(),'Job ')]"));
        private MyWebElement JobTitleDropdownElement = new MyWebElement(By.XPath("//ul[@class='oxd-dropdown-menu']//*[contains(text(),'Job Titles')]"));
        //private MyWebElement NationalitiesButton = new MyWebElement(By.XPath("//*[contains(text(),'Nationalities')]"));
        private MyWebElement EditButton = new MyWebElement(By.XPath("//div[@class='oxd-table-body']/div[1]//i[@class='oxd-icon bi-pencil-fill']"));
        private MyWebElement EditNationalityNameTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space']//input"));
        //private MyWebElement SaveButton = new MyWebElement(By.XPath("//button[@type='submit']"));
        //private MyWebElement EditedNationalityNameTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-table-body']/div[1]/div[1]/div[2]/div"));

        public void ClickUserManagementDropdownButton() => TopbarMenu.ClickTopbarMenuButtonByName("User Management ");

        public void ClickJobDropdownButton() => TopbarMenu.ClickTopbarMenuButtonByName("Job ");

        public void ClickNationalitiesButton() => TopbarMenu.ClickTopbarMenuButtonByName("Nationalities");

        public void ClickEditButton() => EditButton.Click();

        public void ClearNationalityName() => EditNationalityNameTextBoxElement.SendKeys(Keys.Control + "a" + Keys.Delete);

        public void EnterNationalityName(string value) => EditNationalityNameTextBoxElement.SendKeys(value);

        public string ReturnAdminPageHeaderPartOneTextResult() => AdminPageHeaderElementPartOne.Text;

        public string ReturnAdminPageHeaderPartTwoTextResult() => AdminPageHeaderElementPartTwo.Text;

        public string ReturnSystemUserTableHeaderTextResult() => SystemUserTableHeaderElement.Text;

        public string ReturnUsersDropdownElementText() => UsersDropdownElement.Text;

        public string ReturnJobTitleDropdownElementText() => JobTitleDropdownElement.Text;

        //public string ReturnNationalityNameTextBoxElement() => Tables.GetCellText("Nationality");
    }
}
