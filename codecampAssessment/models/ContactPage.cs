using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace codecampAssessment.models
{
    
    class ContactPage
    {
        IWebDriver driver;

        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement name => driver.FindElement(By.Id("forename"));
        private IWebElement surname => driver.FindElement(By.Id("surname"));
        private IWebElement email => driver.FindElement(By.Id("email"));
        private IWebElement telephone => driver.FindElement(By.Id("telephone"));
        private IWebElement message => driver.FindElement(By.Id("message"));

        public void FillName(string fname)
        {
            name.SendKeys(fname);
         //   surname.Click();
        }

        public void FillEmail(String uEmail)
        {
            email.SendKeys(uEmail);
            //surname.Click();
        }

        public void FillMessage(string msg)
        {
           message.SendKeys(msg);
        }
        public void ClickSubmitButton()
        {
            driver.FindElement(By.CssSelector("[aria-label='submit']")).Click();
        }
        public String GetForenameErrorMsg()
        {
            return GetErrorMessage("forename-err");
        }

        public String GetEmailErrorMsg()
        {
            return GetErrorMessage("email-err");
        }

        public String GetMessageErrorMsg()
        {
            return GetErrorMessage("message-err");
        }

        private String GetErrorMessage(String Id)
        {
            return IsErrorMessageDisplayed(Id) ? driver.FindElement(By.Id(Id)).Text : "";
        }

        private bool IsErrorMessageDisplayed(String messageID)
        {
            return driver.FindElement(By.Id(messageID)).Displayed;
        }

     
    }
}
