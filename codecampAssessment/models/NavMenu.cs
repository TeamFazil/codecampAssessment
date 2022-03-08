using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace codecampAssessment.models
{
    public class NavMenu
    {
        private IWebDriver driver;

        public NavMenu(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickContactTab()
        {
            driver.FindElement(By.CssSelector("[aria-label='contact']")).Click();
        }

        public void ClickMenuTab()
        {
            driver.FindElement(By.CssSelector("[aria-label='menu']")).Click();
        }
    }
}
