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
    public class EstimateSummaryPage : BasePage
    {
        public EstimateSummaryPage(IWebDriver driver) : base(driver) { }
        private WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        private IWebElement TotalCostElement => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/c-wiz[1]/div/div/div/div/div/div[2]/div[2]/div[1]/div/div[1]/span[2]")));

        public string GetTotalCost()
        {
            return TotalCostElement.Text;
        }
    }
}
