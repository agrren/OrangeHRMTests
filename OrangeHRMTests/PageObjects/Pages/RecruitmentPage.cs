using OpenQA.Selenium;
using OrangeHRMTests.Common.Extensions.ExtensionMethods;
using OrangeHRMTests.Common.WebElements;
using OrangeHRMTests.PageObjects.Elements;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class RecruitmentPage : BasePage
    {
        private MyWebElement HiringManagerListFirstPosition = new MyWebElement(By.XPath("//div[@role='listbox']/div[1]/span"));

        public string DropDownListJobTitle = "//div[@class='oxd-select-wrapper']/div[2]//*[contains(text(),'{0}')]";

        public void ClickVacanciesButton() => TopbarMenu.ClickTopbarMenuButtonByName("Vacancies");

        public void ClickJobTitleDropdownArrowButton() => Buttons.ClickRequieredDropDownListArrowButtonByName("Job Title");

        public void ClickHiringManagerListFirstPosition() => HiringManagerListFirstPosition.Click();

        public void EnterVacancyName() => Fields.EnterValueInInputTextField("Vacancy Name", "111");

        public void EnterHiringManager() => Fields.EnterValueInInputTextField("Hiring Manager", "a");

        public void ChooseJobTitle() => DropdownExtension.ClickDropdownList("IT Manager");
    }
}
