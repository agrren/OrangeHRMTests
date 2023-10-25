using NUnit.Framework;
using OrangeHRMTests.PageObjects;
using OrangeHRMTests.PageObjects.Elements;

namespace OrangeHRMTests.Tests
{
    public class DemoQATests : BaseTest
    {
        [Test]
        public void A_AboutModalTest()
        {
            GenericPages.DashboardPage.ClickArrowButton();
            GenericPages.AboutPage.ClickAboutButton();
            Assert.AreEqual("About", GenericPages.AboutPage.ReturnAboutNameTextResult());
            Assert.AreEqual("OrangeHRM OS 5.5", GenericPages.AboutPage.ReturnAboutVersionTextResult());

            GenericPages.AboutPage.ClickCloseAboutButton();
        }

        [Test]
        public void B_SupportPageTest()
        {
            GenericPages.DashboardPage.ClickArrowButton();
            GenericPages.SupportPage.ClickSupport();
            Assert.AreEqual("Getting Started with OrangeHRM", GenericPages.SupportPage.ReturnSupportTitleTextResult());
        }

        [Test]
        public void C_DashboardPageTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToDashboardPage();
            Assert.AreEqual("Time at Work", GenericPages.DashboardPage.ReturnTimeAtWorkTextResult());
            Assert.AreEqual("My Actions", GenericPages.DashboardPage.ReturnMyActionTextResult());
            Assert.AreEqual("Quick Launch", GenericPages.DashboardPage.ReturnQuckLaunchTextResult());
            Assert.AreEqual("Buzz Latest Posts", GenericPages.DashboardPage.ReturnBuzzLatestPostTextResult());
            Assert.AreEqual("Employees on Leave Today", GenericPages.DashboardPage.ReturnOnLeaveTextResult());
            Assert.AreEqual("Employee Distribution by Sub Unit", GenericPages.DashboardPage.ReturnBySubUnitTextResult());
            Assert.AreEqual("Employee Distribution by Location", GenericPages.DashboardPage.ReturnByLocationTextResult());

            GenericPages.DashboardPage.ClickWheelButton();
            Assert.AreEqual("Configurations", GenericPages.DashboardPage.ReturnConfigTextResult());

            GenericPages.DashboardPage.ClickCrossButton();
            GenericPages.DashboardPage.ClickWheelButton();
            Assert.AreEqual("Configurations", GenericPages.DashboardPage.ReturnConfigTextResult());

            GenericPages.DashboardPage.ClickCancelButton();
        }

        [Test]
        public void D_AdminPageTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToAdminPage();

            var username = Tables.GetCellText("Username");
            var userRole = Tables.GetCellText("User Role");
            var employeename = Tables.GetCellText("Employee Name");
            var userStatus = Tables.GetCellText("Status");

            Assert.AreEqual("Admin", GenericPages.AdminPage.ReturnAdminPageHeaderPartOneTextResult());
            Assert.AreEqual("User Management", GenericPages.AdminPage.ReturnAdminPageHeaderPartTwoTextResult());
            Assert.AreEqual("System Users", GenericPages.AdminPage.ReturnSystemUserTableHeaderTextResult());

            GenericPages.AdminUserManagement.EnterUserName();
            GenericPages.AdminUserManagement.ClickUserRoleDropdownArrow();
            GenericPages.AdminUserManagement.ChooseUserRole();
            GenericPages.AdminUserManagement.EnterEmployeeName();
            GenericPages.AdminUserManagement.ClickUserStatusDropdownArrow();
            GenericPages.AdminUserManagement.ChooseUserStatus();
            Buttons.ClickSearchButton();

            Assert.AreEqual(username, Tables.GetCellText("Username"));
            Assert.AreEqual(userRole, Tables.GetCellText("User Role"));
            Assert.AreEqual(employeename, Tables.GetCellText("Employee Name"));
            Assert.AreEqual(userStatus, Tables.GetCellText("Status"));
        }

        [Test]
        public void E_PIMPageAddEmployeeTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToPIMPage();
            Buttons.ClickAddButton();
            GenericPages.PIMPage.EnterFirstName();
            GenericPages.PIMPage.EnterMiddleName();
            GenericPages.PIMPage.EnterLastName();
            GenericPages.PIMPage.ClickSaveOneButton();
            GenericPages.PIMPage.ClickSaveTwoButton();
            GenericPages.PIMPage.ClickEmployeeListButton();

            Assert.AreEqual("111 222", GenericPages.PIMPage.ReturnFirstAndMiddleNameTextResult());
            Assert.AreEqual("333", GenericPages.PIMPage.ReturnLastNameTextResult());

            GenericPages.BasePage.DeleteCreatedUser();
        }

        [Test]
        public void F_SearchFunctionalityTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.EnterValueToSearchInputField("PIM");
            GenericPages.BasePage.LeftMenuNavigationPanel.PressEnter();

            Assert.AreEqual("PIM", GenericPages.BasePage.LeftMenuNavigationPanel.ReturnSearchResultText());

            GenericPages.BasePage.LeftMenuNavigationPanel.ClearSearchInputField();
        }

        [Test]
        public void G_PerformanceManagementTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToPerformancePage();
            GenericPages.PerformancePage.ClickConfigureButton();
            GenericPages.PerformancePage.ClickKPIsButton();
            Buttons.ClickAddButton();
            GenericPages.PerformancePage.EnterKeyPerformanceIndicator();
            GenericPages.PerformancePage.ClickJobTitleDropdownArrowButton();
            GenericPages.PerformancePage.ChooseJobTitle();
            GenericPages.PerformancePage.EnterKeyMinimumRating();
            Buttons.ClickSaveButton();

            Assert.AreEqual("111", Tables.GetCellText("Key Performance Indicator"));
            Assert.AreEqual("IT Manager", Tables.GetCellText("Job Title"));
            Assert.AreEqual("1", Tables.GetCellText("Min Rate"));

            Tables.ClickTrashButton();
            Buttons.ClickConfirmDeletionButton();

            Assert.AreNotEqual("111", Tables.GetCellText("Key Performance Indicator"));
            Assert.AreNotEqual("IT Manager", Tables.GetCellText("Job Title"));
            Assert.AreNotEqual("1", Tables.GetCellText("Min Rate"));
        }

        [Test]
        public void H_AdminFunctionalityTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToAdminPage();

            GenericPages.AdminPage.ClickUserManagementDropdownButton();

            Assert.AreEqual("Users", GenericPages.AdminPage.ReturnUsersDropdownElementText());

            GenericPages.AdminPage.ClickJobDropdownButton();

            Assert.AreEqual("Job Titles", GenericPages.AdminPage.ReturnJobTitleDropdownElementText());
        }

        [Test]
        public void I_EditNationalityTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToAdminPage();

            GenericPages.AdminPage.ClickNationalitiesButton();
            var nationality = Tables.GetCellText("Nationality");
            Tables.ClickPencilEditButton();
            GenericPages.AdminPage.ClearNationalityName();
            GenericPages.AdminPage.EnterNationalityName("111");
            Buttons.ClickSaveButton();

            Assert.AreEqual("111", Tables.GetCellText("Nationality"));

            Tables.ClickPencilEditButton();
            GenericPages.AdminPage.ClearNationalityName();
            GenericPages.AdminPage.EnterNationalityName(nationality);
            Buttons.ClickSaveButton();

            Assert.AreEqual(nationality, Tables.GetCellText("Nationality"));
        }

        [Test]
        public void J_RecruitmentManagementFunctionalityTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToRecruitmentPage();
            GenericPages.RecruitmentPage.ClickVacanciesButton();
            Buttons.ClickAddButton();
            GenericPages.RecruitmentPage.EnterVacancyName();
            GenericPages.RecruitmentPage.ClickJobTitleDropdownArrowButton();
            GenericPages.RecruitmentPage.ChooseJobTitle();
            GenericPages.RecruitmentPage.EnterHiringManager();
            GenericPages.RecruitmentPage.ClickHiringManagerListFirstPosition();
            Buttons.ClickSaveButton();
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToRecruitmentPage();
            GenericPages.RecruitmentPage.ClickVacanciesButton();


            Assert.AreEqual("111", Tables.GetCellText("Vacancy"));
            Assert.AreEqual("IT Manager", Tables.GetCellText("Job Title"));
            Assert.AreEqual("Active", Tables.GetCellText("Status"));

            Tables.ClickTrashButton();
            Buttons.ClickConfirmDeletionButton();

            Assert.AreNotEqual("111", Tables.GetCellText("Vacancy"));
        }

        [Test]
        public void K_AssignLeaveTest()
        {
            GenericPages.BasePage.LeftMenuNavigationPanel.GoToPIMPage();
            Buttons.ClickAddButton();
            GenericPages.PIMPage.EnterFirstName();
            GenericPages.PIMPage.EnterMiddleName();
            GenericPages.PIMPage.EnterLastName();
            GenericPages.PIMPage.ClickSaveOneButton();
            GenericPages.PIMPage.ClickSaveTwoButton();
            GenericPages.PIMPage.ClickEmployeeListButton();

            GenericPages.BasePage.LeftMenuNavigationPanel.GoToLeavePage();
            GenericPages.LeavePage.ClickEntitlementsButton();
            GenericPages.LeavePage.ClickAddEntitlementsButton();
            GenericPages.LeavePage.EnterEmployeeName();
            GenericPages.LeavePage.ClickCreatedEmployeeFirstPosition();
            GenericPages.LeavePage.ClickLeaveTypeArrowButton();
            GenericPages.LeavePage.ChooseLeaveType();
            GenericPages.LeavePage.EnterEntitlement();
            Buttons.ClickSaveButton();
            GenericPages.LeavePage.ClickConfirmButton();

            GenericPages.LeavePage.ClickAssignLeaveButton();
            GenericPages.LeavePage.EnterEmployeeName();
            GenericPages.LeavePage.ClickCreatedEmployeeFirstPosition();
            GenericPages.LeavePage.ClickLeaveTypeArrowButton();
            GenericPages.LeavePage.ChooseLeaveType();
            //Implementation of wait while element appears - was discussed
            string ReturnLeaveBalanceTextResult() => GenericPages.LeavePage.LeaveBalanceTextElement.Text;
            Assert.AreEqual("10.00 Day(s)", ReturnLeaveBalanceTextResult());
            //
            GenericPages.LeavePage.ClickFromDateCalendarButton();
            GenericPages.LeavePage.ClickFromDateCalendarValueButton();
            GenericPages.LeavePage.ClickToDateCalendarButton();
            GenericPages.LeavePage.ClickToDateCalendarValueButton();
            Buttons.ClickSaveButton();
            //Implementation of wait while element appears - was discussed
            string ReturnSuccessfullySavedMessageTextResult() => GenericPages.LeavePage.SuccessfullySavedMessageTextElement.Text;
            Assert.AreEqual("Successfully Saved", ReturnSuccessfullySavedMessageTextResult());
            //

            GenericPages.LeavePage.ClickLeaveListButton();
            GenericPages.LeavePage.ClickShowLeaveWithStatusTypeArrowButton();
            GenericPages.LeavePage.ChooseShowLeaveWithStatusType();
            GenericPages.LeavePage.ClickNotRequiredLeaveTypeArrowButton();
            GenericPages.LeavePage.ChooseLeaveType();
            GenericPages.LeavePage.EnterEmployeeName();
            GenericPages.LeavePage.ClickCreatedEmployeeFirstPosition();
            Buttons.ClickSearchButton();

            Assert.AreEqual("111 222 333", Tables.GetCellText("Employee Name"));

            GenericPages.BasePage.DeleteCreatedUser();

            //GenericPages.BasePage.LeftMenuNavigationPanel.GoToPIMPage();
            //GenericPages.PIMPage.EnterEmployeeNameHintedTextBoxElement();
            //GenericPages.LeavePage.ClickCreatedEmployeeFirstPosition();
            //GenericPages.LeavePage.ClickSearchButton();
            //GenericPages.PIMPage.ClickTrashButton();
            //GenericPages.PIMPage.ClickYesDeleteButton();
        }
    }
}