using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;
using OrangeHRMTests.Data;

namespace OrangeHRMTests.PageObjects
{
    public class LoginPage : BasePage
    {
        private MyWebElement UserNameField = new MyWebElement(By.XPath("//*[@name='username']"));
        private MyWebElement PassWordField = new MyWebElement(By.XPath("//*[@name='password']"));
        private MyWebElement LoginButton = new MyWebElement(By.XPath("//*[@type='submit']"));
        private MyWebElement InvalidMessageTextElement = new MyWebElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
        private MyWebElement LogoutButton = new MyWebElement(By.XPath("//a[@href='/web/index.php/auth/logout']"));

        public string GetCurrentPageUrl() => Driver.Url;

        public void EnterValidUsername() => UserNameField.SendKeys(TestSettings.username);

        public void EnterValidPassword() => PassWordField.SendKeys(TestSettings.password);

        public void ClickLoginButton() => LoginButton.Click();

        public void EnterInvalidUsername() => UserNameField.SendKeys(TestSettings.wusername);

        public void EnterInvalidPassword() => PassWordField.SendKeys(TestSettings.wpassword);

        public void ClickLogout() => LogoutButton.Click();

        public string ReturnInvalidMessageTextResult() => InvalidMessageTextElement.Text;

        public void LogInToOrangeCRM()
        {
            EnterValidUsername();
            EnterValidPassword();
            ClickLoginButton();
        }
    }
}
