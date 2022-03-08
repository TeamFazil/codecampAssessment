using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codecampAssessment.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace codecampAssessment
{
    [TestClass]
    public class ViganPizzaPrice_Tests:BaseTest
    {
        [TestMethod]
        public void MenuPage_verifyVeganPizzaPrice()
        {
            //Arrange
            NavMenu navMenu = new(driver);
            navMenu.ClickMenuTab();
            MenuItemsPage menuPage = new MenuItemsPage(driver);
            //Act

            //Assert

            foreach (IWebElement element in menuPage.FindAllVeganPizzas()){
                Assert.AreEqual("$14.99", element.FindElement(By.ClassName("price")).Text);
               
            }
           
          

           
        }

    }
}
