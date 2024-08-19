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
        [Test]
        public void AddToEstimateTest()
        {
            var calculatorPage = new GoogleCloudCalculatorPage(driver);

            calculatorPage.ClickAddToEstimate();
            calculatorPage.SelectComputeEngine();
            calculatorPage.EnterNumberOfInstances("4");
            calculatorPage.SelectOperatingSystem();
            calculatorPage.SelectProvisioningModel();
            calculatorPage.SelectMachineFamily();
            calculatorPage.SelectSeries();
            calculatorPage.SelectMachineType();
            calculatorPage.AddGPUs();
            calculatorPage.SelectLocalSsd();
            calculatorPage.SelectLocation();
            Thread.Sleep(5000);
            calculatorPage.ClickShare();
            Thread.Sleep(4000);
            calculatorPage.ClickEstimateSummary();

            string expectedTotalCost = "$8,935.06";
            var tabs = driver.WindowHandles;
            driver.SwitchTo().Window(tabs[1]);
            var estimateSummaryPage = new EstimateSummaryPage(driver);
            Thread.Sleep(3000);
            string actualTotalCost = estimateSummaryPage.GetTotalCost();
            Assert.That(actualTotalCost, Is.EqualTo(expectedTotalCost));
        }
    }
}
