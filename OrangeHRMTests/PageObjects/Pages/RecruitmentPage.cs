using OpenQA.Selenium;
using OrangeHRMTests.Common.Drivers;
using OrangeHRMTests.Common.Extensions.ExtensionMethods;
using OrangeHRMTests.Common.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMTests.PageObjects.Pages
{
    public class RecruitmentPage : BasePage
    {
        private MyWebElement VacanciesButton = new MyWebElement(By.XPath("//*[contains(text(),'Vacancies')]"));
        private MyWebElement VacancyNameTextBoxElement = new MyWebElement(By.XPath("//form[@class='oxd-form']/div[1]//input"));
        private MyWebElement JobTitleDropdownArrowButton = new MyWebElement(By.XPath("//form[@class='oxd-form']/div[1]/div[@class='oxd-grid-item oxd-grid-item--gutters']//*[contains(text(),'Job Title')]//ancestor::div[1]//following-sibling::div//i"));
        private MyWebElement HiringManagerTextBoxElement = new MyWebElement(By.XPath("//div[@class='oxd-autocomplete-text-input oxd-autocomplete-text-input--active']//input"));
        private MyWebElement HiringManagerListFirstPosition = new MyWebElement(By.XPath("//div[@role='listbox']/div[1]/span"));
        private MyWebElement VacancyCreatedEntryTrashButton = new MyWebElement(By.XPath("//div[@class='oxd-table-body']/div[1]/div[1]//i[@class='oxd-icon bi-trash']"));

        public string DropDownListJobTitle = "//div[@class='oxd-select-wrapper']/div[2]//*[contains(text(),'{0}')]";

        public void ClickVacanciesButton() => VacanciesButton.Click();

        public void ClickJobTitleDropdownArrowButton() => Buttons.Buttons.ClickRequieredDropDownListArrowButtonByName("Job Title");

        public void ClickHiringManagerTextBoxElement() => HiringManagerTextBoxElement.Click();

        public void ClickHiringManagerListFirstPosition() => HiringManagerListFirstPosition.Click();

        public void ClickVacancyCreatedEntryTrashButton() => VacancyCreatedEntryTrashButton.Click();

        public void EnterVacancyName() => VacancyNameTextBoxElement.SendKeys("111");

        public void EnterHiringManager() => HiringManagerTextBoxElement.SendKeys("a");

        public void ChooseJobTitle() => DropdownExtension.ClickDropdownList("IT Manager");

        public string ReturnHiringManagerListFirstPositionText() => HiringManagerTextBoxElement.Text;
    }
}
