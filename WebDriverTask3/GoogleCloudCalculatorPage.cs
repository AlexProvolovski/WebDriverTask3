using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTask3
{
    public class GoogleCloudCalculatorPage : BasePage
    {
        private readonly WebDriverWait wait;
#pragma warning disable CS8618
        public GoogleCloudCalculatorPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        #region Find_Page_Elements

        [FindsBy(How = How.XPath, Using = "//span[text()='Add to estimate']")]
        private IWebElement AddToEstimateButton;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Compute Engine')]")]
        private IWebElement ComputeEngineOption;

        [FindsBy(How = How.Id, Using = "c13")]
        private IWebElement NumberOfInstances;

        [FindsBy(How = How.CssSelector, Using = "[placeholder-id='ucc-25']")]
        private IWebElement OperatingSystemDropdown;

        [FindsBy(How = How.CssSelector, Using = "[data-value='free-debian-centos-coreos-ubuntu-or-byol-bring-your-own-license']")]
        private IWebElement OperatingSystemOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[9]/div/div/div[2]/div/div/div[1]/label")]
        private IWebElement ProvisioningModelButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div")]
        private IWebElement MachineFamilyDropdown;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[1]/div/div/div/div[2]/ul/li[1]")]
        private IWebElement MachineFamilyOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/div")]
        private IWebElement SeriesDropdown;

        [FindsBy(How = How.CssSelector, Using = "[data-value='n1']")]
        private IWebElement SeriesOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div")]
        private IWebElement MachineTypeDropdown;

        [FindsBy(How = How.CssSelector, Using = "[data-value='n1-standard-8']")]
        private IWebElement MachineTypeOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[21]/div/div/div[1]/div/div/span/div/button/div/span[1]")]
        private IWebElement AddGPUsCheckbox;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]/div")]
        private IWebElement GpuTypeDropdown;

        [FindsBy(How = How.CssSelector, Using = "[data-value='nvidia-tesla-v100']")]
        private IWebElement GpuTypeOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[24]/div/div[1]/div/div/div/div[1]/div")]
        private IWebElement NumberOfGpusDropdown;

        [FindsBy(How = How.CssSelector, Using = "[data-value='1']")]
        private IWebElement NumberOfGpusOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div")]
        private IWebElement LocalSsdDropdown;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]")]
        private IWebElement LocalSsdOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[1]/div")]
        private IWebElement LocationDropdown;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[2]/ul/li[5]")]
        private IWebElement LocationOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow5']/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[2]/div/button/span[6]")]
        private IWebElement ShareButton;

        [FindsBy(How = How.CssSelector, Using = "[track-name='open estimate summary']")]
        private IWebElement EstimateSummaryButton;

        #endregion

        #region Execution_Methods

        public void SelectComputeEngine()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(ComputeEngineOption)).Click();
        }

        public void EnterNumberOfInstances(string number)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfInstances)).Clear();
            wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfInstances)).SendKeys(number);
        }

        public void SelectOperatingSystem()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(OperatingSystemDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(OperatingSystemOption)).Click();
        }

        public void SelectProvisioningModel()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(ProvisioningModelButton)).Click();
        }

        public void SelectMachineFamily()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(MachineFamilyDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(MachineFamilyOption)).Click();
        }

        public void SelectSeries()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(SeriesDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SeriesOption)).Click();
        }

        public void SelectMachineType()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(MachineTypeDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(MachineTypeOption)).Click();
        }

        public void AddGPUs()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(AddGPUsCheckbox)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(GpuTypeDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(GpuTypeOption)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfGpusDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfGpusOption)).Click();
        }

        public void SelectLocalSsd()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(LocalSsdDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(LocalSsdOption)).Click();
        }

        public void SelectLocation()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(LocationDropdown)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(LocationOption)).Click();
        }

        public void ClickAddToEstimate()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(AddToEstimateButton)).Click();
        }

        public void ClickShare()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(ShareButton)).Click();
        }

        public void ClickEstimateSummary()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(EstimateSummaryButton)).Click();
        }

        #endregion
    }
}