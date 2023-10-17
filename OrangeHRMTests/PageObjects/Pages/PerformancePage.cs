using OpenQA.Selenium;
using OrangeHRMTests.Common.Extensions.ExtensionMethods;
using OrangeHRMTests.Common.WebElements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class PerformancePage : BasePage
    {
        private MyWebElement ConfigureButton = new MyWebElement(By.XPath("//nav[@aria-label='Topbar Menu']//*[contains(text(),'Configure')]"));
        private MyWebElement KPIsButton = new MyWebElement(By.XPath("//nav[@aria-label='Topbar Menu']//*[contains(text(),'KPIs')]"));
        private MyWebElement KeyPerformanceIndicatorInputBox = new MyWebElement(By.XPath("//div[@class='oxd-grid-2 orangehrm-full-width-grid']//input"));
        private MyWebElement MinimumRatingInputBox = new MyWebElement(By.XPath("//div[@class='oxd-grid-4 orangehrm-full-width-grid']/div[1]/div[1]//input"));
        private MyWebElement KeyPerformanceIndicatorTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-table']/div[2]/div[1]/div[1]/div[2]"));
        private MyWebElement JobTitleTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-table']/div[2]/div[1]/div[1]/div[3]"));
        private MyWebElement MinRateTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-table']/div[2]/div[1]/div[1]/div[4]"));

        public string DropDownListJobTitle = "//div[@class='oxd-select-wrapper']/div[2]//*[contains(text(),'{0}')]";

        public void ClickConfigureButton() => ConfigureButton.Click();

        public void ClickKPIsButton() => KPIsButton.Click();

        public void EnterKeyPerformanceIndicator() => KeyPerformanceIndicatorInputBox.SendKeys("111");

        public void EnterKeyMinimumRating() => MinimumRatingInputBox.SendKeys("1");

        public void ClickJobTitleDropdownArrowButton() => Buttons.Buttons.ClickRequieredDropDownListArrowButtonByName("Job Title");

        public void ChooseJobTitle() => DropdownExtension.ClickDropdownList("IT Manager");

        public string ReturnKeyPerformanceIndicatorTextResult() => KeyPerformanceIndicatorTextBoxElement.Text;

        public string ReturnJobTitleTextResult() => JobTitleTextBoxElement.Text;

        public string ReturnMinRateTextResult() => MinRateTextBoxElement.Text;
    }
}
