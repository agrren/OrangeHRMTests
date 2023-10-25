using OpenQA.Selenium;
using OrangeHRMTests.Common.Extensions.ExtensionMethods;
using OrangeHRMTests.Common.WebElements;
using OrangeHRMTests.PageObjects.Elements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class PerformancePage : BasePage
    {
        //private MyWebElement ConfigureButton = new MyWebElement(By.XPath("//nav[@aria-label='Topbar Menu']//*[contains(text(),'Configure')]"));
        //private MyWebElement KPIsButton = new MyWebElement(By.XPath("//nav[@aria-label='Topbar Menu']//*[contains(text(),'KPIs')]"));
        //private MyWebElement KeyPerformanceIndicatorInputBox = new MyWebElement(By.XPath("//div[@class='oxd-grid-2 orangehrm-full-width-grid']//input"));
        //private MyWebElement MinimumRatingInputBox = new MyWebElement(By.XPath("//div[@class='oxd-grid-4 orangehrm-full-width-grid']/div[1]/div[1]//input"));
        //private MyWebElement KeyPerformanceIndicatorTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-table']/div[2]/div[1]/div[1]/div[2]"));
        //private MyWebElement JobTitleTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-table']/div[2]/div[1]/div[1]/div[3]"));
        //private MyWebElement MinRateTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-table']/div[2]/div[1]/div[1]/div[4]"));

        //private string DropDownListJobTitle = "//div[@class='oxd-select-wrapper']/div[2]//*[contains(text(),'{0}')]";
        //private string TopbarMenuButtonByName = "//nav[@aria-label='Topbar Menu']//*[contains(text(),'{0}')]";
        private string AddKeyPerformanceIndicatorFieldByName = "//label[text() = '{0}']//ancestor::div[1]/following-sibling::*/*";

        //public void ClickTopbarMenuButtonByName(string value) => new MyWebElement(By.XPath(string.Format(TopbarMenuButtonByName, value))).Click();

        public void ClickConfigureButton() => TopbarMenu.ClickTopbarMenuButtonByName("Configure");

        public void ClickKPIsButton() => TopbarMenu.ClickTopbarMenuButtonByName("KPIs");

        public void EnterKeyPerformanceIndicatorFieldByName(string fieldname, string value) => new MyWebElement(By.XPath(string.Format(AddKeyPerformanceIndicatorFieldByName, fieldname))).SendKeys(value);

        public void EnterKeyPerformanceIndicator() => EnterKeyPerformanceIndicatorFieldByName("Key Performance Indicator", "111");

        public void EnterKeyMinimumRating() => EnterKeyPerformanceIndicatorFieldByName("Minimum Rating", "1");

        public void ClickJobTitleDropdownArrowButton() => Buttons.ClickRequieredDropDownListArrowButtonByName("Job Title");

        public void ChooseJobTitle() => DropdownExtension.ClickDropdownList("IT Manager");

        //public string ReturnKeyPerformanceIndicatorTextResult() => KeyPerformanceIndicatorTextBoxElement.Text;

        //public string ReturnJobTitleTextResult() => JobTitleTextBoxElement.Text;

        //public string ReturnMinRateTextResult() => MinRateTextBoxElement.Text;
    }
}
