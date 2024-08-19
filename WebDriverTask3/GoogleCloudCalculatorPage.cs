using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public GoogleCloudCalculatorPage(IWebDriver driver) : base(driver) { }

        private WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        
        private IWebElement AddToEstimateButton => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Add to estimate']")));
        private IWebElement ComputeEngineOption => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[contains(text(), 'Compute Engine')]")));
        private IWebElement NumberOfInstances => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("c13")));
        private IWebElement OperatingSystemDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[placeholder-id='ucc-25']")));
        private IWebElement OperatingSystemOption => wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-value='free-debian-centos-coreos-ubuntu-or-byol-bring-your-own-license']")));
        private IWebElement ProvisioningModelButton => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[9]/div/div/div[2]/div/div/div[1]/label")));
        private IWebElement MachineFamilyDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div")));
        private IWebElement MachineFamilyOption => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[1]/div/div/div/div[2]/ul/li[1]")));
        private IWebElement SeriesDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/div")));
        private IWebElement SeriesOption => wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-value='n1']")));
        private IWebElement MachineTypeDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div")));
        private IWebElement MachineTypeOption => wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-value='n1-standard-8']")));
        private IWebElement AddGPUsCheckbox => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[21]/div/div/div[1]/div/div/span/div/button/div/span[1]")));
        private IWebElement GpuTypeDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]/div")));
        private IWebElement GpuTypeOption => wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-value='nvidia-tesla-v100']")));
        private IWebElement NumberOfGpusDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[24]/div/div[1]/div/div/div/div[1]/div")));
        private IWebElement NumberOfGpusOption => wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-value='1']")));
        private IWebElement LocalSsdDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div")));
        private IWebElement LocalSsdOption => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]")));
        private IWebElement LocationDropdown => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[1]/div")));
        private IWebElement LocationOption => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[2]/ul/li[5]")));
        private IWebElement ShareButton => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[2]/div/button/span[6]")));
        private IWebElement EstimateSummaryButton => wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[track-name='open estimate summary']")));

        public void SelectComputeEngine()
        {
            ComputeEngineOption.Click();
        }

        public void EnterNumberOfInstances(string number)
        {
            NumberOfInstances.Clear();
            NumberOfInstances.SendKeys(number);
        }

        public void SelectOperatingSystem()
        {
            OperatingSystemDropdown.Click();
            OperatingSystemOption.Click();
        }

        public void SelectProvisioningModel()
        {
            ProvisioningModelButton.Click();
        }

        public void SelectMachineFamily()
        {
            MachineFamilyDropdown.Click();
            MachineFamilyOption.Click();
        }

        public void SelectSeries()
        {
            SeriesDropdown.Click();
            SeriesOption.Click();
        }

        public void SelectMachineType()
        {
            MachineTypeDropdown.Click();
            MachineTypeOption.Click();
        }

        public void AddGPUs()
        {
            AddGPUsCheckbox.Click();
            GpuTypeDropdown.Click();
            GpuTypeOption.Click();
            NumberOfGpusDropdown.Click();
            NumberOfGpusOption.Click();
        }

        public void SelectLocalSsd()
        {
            LocalSsdDropdown.Click();
            LocalSsdOption.Click();
        }

        public void SelectLocation()
        {
            LocationDropdown.Click();
            LocationOption.Click();
        }

        public void ClickAddToEstimate()
        {
            AddToEstimateButton.Click();
        }

        public void ClickShare()
        {
            ShareButton.Click();
        }

        public void ClickEstimateSummary()
        {
            EstimateSummaryButton.Click();
        }

    }
}
