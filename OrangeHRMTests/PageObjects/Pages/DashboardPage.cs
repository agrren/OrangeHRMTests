using OpenQA.Selenium;
using OrangeHRMTests.Common.WebElements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class DashboardPage : BasePage
    {
        private MyWebElement ArrowButton = new MyWebElement(By.XPath("//i[@class='oxd-icon bi-caret-down-fill oxd-userdropdown-icon']"));
        private MyWebElement TimeAtWorkTextElement = new MyWebElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-dashboard-grid']/div[1]/div[1]/div[1]/div[1]/p"));
        private MyWebElement MyActionTextElement = new MyWebElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-dashboard-grid']/div[2]/div[1]/div[1]/div[1]/p"));
        private MyWebElement QuickLaunchTextElement = new MyWebElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-dashboard-grid']/div[3]/div[1]/div[1]/div[1]/p"));
        private MyWebElement BuzzLatestPostTextElement = new MyWebElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-dashboard-grid']/div[4]/div[1]/div[1]/div[1]/p"));
        private MyWebElement OnLeaveTextElement = new MyWebElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-dashboard-grid']/div[5]/div[1]/div[1]/div[1]/p"));
        private MyWebElement BySubUnitTextElement = new MyWebElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-dashboard-grid']/div[6]/div[1]/div[1]/div[1]/p"));
        private MyWebElement ByLocationTextElement = new MyWebElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-dashboard-grid']/div[7]/div[1]/div[1]/div[1]/p"));
        private MyWebElement WheelButton = new MyWebElement(By.XPath("//i[@class='oxd-icon bi-gear-fill orangehrm-leave-card-icon']"));
        private MyWebElement ConfigurationsTextElement = new MyWebElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-text--card-title']"));
        private MyWebElement CrossButton = new MyWebElement(By.XPath("//button[@class='oxd-dialog-close-button oxd-dialog-close-button-position']"));
        private MyWebElement CancelButton = new MyWebElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--ghost']"));

        public void ClickArrowButton() => ArrowButton.Click();

        public void ClickWheelButton() => WheelButton.Click();

        public void ClickCrossButton() => CrossButton.Click();

        public void ClickCancelButton() => CancelButton.Click();

        public string ReturnTimeAtWorkTextResult() => TimeAtWorkTextElement.Text;

        public string ReturnMyActionTextResult() => MyActionTextElement.Text;

        public string ReturnQuckLaunchTextResult() => QuickLaunchTextElement.Text;

        public string ReturnBuzzLatestPostTextResult() => BuzzLatestPostTextElement.Text;

        public string ReturnOnLeaveTextResult() => OnLeaveTextElement.Text;

        public string ReturnBySubUnitTextResult() => BySubUnitTextElement.Text;

        public string ReturnByLocationTextResult() => ByLocationTextElement.Text;

        public string ReturnConfigTextResult() => ConfigurationsTextElement.GetAttribute("innerText");
    }
}
