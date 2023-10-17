using NUnit.Framework;
using OrangeHRMTests.Common.Drivers;
using OrangeHRMTests.Data.Constants;
using OrangeHRMTests.PageObjects;

namespace OrangeHRMTests.Tests
{
    public class LoginTests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            WebDriverFactory.InitializeDriver();
            GenericPages.BasePage.GoToLoginPage();
        }

        [Test]
        public void A_ValidLoginTest()
        {
            GenericPages.LoginPage.EnterValidUsername();
            GenericPages.LoginPage.EnterValidPassword();
            GenericPages.LoginPage.ClickLoginButton();
            Assert.AreEqual(DashboardPageConstants.DashboardPageUrl, GenericPages.LoginPage.GetCurrentPageUrl());

            GenericPages.DashboardPage.ClickArrowButton();
            GenericPages.LoginPage.ClickLogout();
        }

        [Test]
        public void B_InValidLoginTest()
        {
            GenericPages.LoginPage.EnterInvalidUsername();
            GenericPages.LoginPage.EnterInvalidPassword();
            GenericPages.LoginPage.ClickLoginButton();
            Assert.AreEqual("Invalid credentials", GenericPages.LoginPage.ReturnInvalidMessageTextResult());
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverFactory.QuitDriver();
        }
    }
}
