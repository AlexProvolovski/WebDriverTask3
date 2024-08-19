using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask3;

namespace Tests
{
    internal class GoogleCloudCalculatorTest : BaseTest
    {
        private CalculatorOptions options;

        [SetUp]
        public void InitOptions()
        {
            options = new CalculatorOptions
            {
                NumberOfInstances = 4,
                OperatingSystem = "Free: Debian, CentOS, CoreOS, Ubuntu or BYOL",
                ProvisioningModel = "Regular",
                MachineFamily = "n1",
                Series = "N1",
                MachineType = "n1-standard-8",
                GpuType = "NVIDIA_TESLA_V100",
                NumberOfGpus = 1,
                LocalSsd = "2x375 GB",
                Location = "europe-west4"
            };
        }

        [Test]
        public void AddToEstimateTest()
        {
            var calculatorPage = new GoogleCloudCalculatorPage(driver);

            calculatorPage.ClickAddToEstimate();
            calculatorPage.SelectComputeEngine();
            calculatorPage.EnterNumberOfInstances(options.NumberOfInstances.ToString());
            calculatorPage.SelectOperatingSystem();
            calculatorPage.SelectProvisioningModel();
            calculatorPage.SelectMachineFamily();
            calculatorPage.SelectSeries();
            calculatorPage.SelectMachineType();
            calculatorPage.AddGPUs();
            calculatorPage.SelectLocalSsd();
            calculatorPage.SelectLocation();
            Thread.Sleep(3000);
            calculatorPage.ClickShare();
            Thread.Sleep(3000);
            calculatorPage.ClickEstimateSummary();

            string expectedTotalCost = "$8,935.06";
            var tabs = driver.WindowHandles;
            driver.SwitchTo().Window(tabs[1]);
            var estimateSummaryPage = new EstimateSummaryPage(driver);
            string actualTotalCost = estimateSummaryPage.GetTotalCost();
            Assert.That(actualTotalCost, Is.EqualTo(expectedTotalCost));
        }
    }
}
