using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace codecampAssessment
{
    [TestClass]
    public class BaseTest
    {
        public IWebDriver driver;
        [TestInitialize]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://d2ju5vf8ca0qio.cloudfront.net/#/";
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }

        public void wait(int time)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time));
        }
    }
}
