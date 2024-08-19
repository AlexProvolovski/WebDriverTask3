using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.IO;
using OpenQA.Selenium.DevTools.V85.HeadlessExperimental;

namespace Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://cloud.google.com/products/calculator");
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png");
                screenshot.SaveAsFile(filePath);
            }
            driver.Quit();
        }

    }
}
