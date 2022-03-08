using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codecampAssessment.models;
using OpenQA.Selenium;

namespace codecampAssessment
{
    public class MenuItemsPage
    {
        IWebDriver driver;

        public MenuItemsPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public IReadOnlyCollection<IWebElement> FindAllVeganPizzas()
        {
           
          return driver.FindElements(By.ClassName("vegan"));
       
        }

       

    }
}
