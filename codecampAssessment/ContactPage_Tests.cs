using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codecampAssessment.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codecampAssessment
{
    [TestClass]
    public class ContactPage_Tests:BaseTest
    {
        [TestMethod]
        public void Forename_verifyErrorMessage()
        {
            //Arrange
            NavMenu navMenu = new(driver);
           
            navMenu.ClickContactTab();

            //Act
            ContactPage contactPage = new ContactPage(driver);
            contactPage.ClickSubmitButton();
            wait(3);

            //Assert
            Assert.AreEqual("Forename is required", contactPage.GetForenameErrorMsg());
        }

        [TestMethod]
        public void Forename_verifyNoErrorMessage()
        {
            //Arrange
            NavMenu navMenu = new(driver);
            navMenu.ClickContactTab();

            //Act
            ContactPage contactPage = new ContactPage(driver);
            contactPage.FillName("Dan");
            wait(3);
            //Assert
            Assert.AreEqual("", contactPage.GetForenameErrorMsg());
        }

        [TestMethod]
        public void Email_verifyErrorMessage()
        {
            //Arrange
            NavMenu navMenu = new(driver);

            navMenu.ClickContactTab();

            //Act
            ContactPage contactPage = new ContactPage(driver);
            contactPage.ClickSubmitButton();
            wait(3);

            //Assert
            Assert.AreEqual("Email is required", contactPage.GetEmailErrorMsg());
        }

        [TestMethod]
        public void Email_verifyNoErrorMessage()
        {
            //Arrange
            NavMenu navMenu = new(driver);

            navMenu.ClickContactTab();

            //Act
            ContactPage contactPage = new ContactPage(driver);
            contactPage.FillEmail("dan@abc.com");
            wait(3);

            //Assert
            Assert.AreEqual("", contactPage.GetForenameErrorMsg());
        }

        [TestMethod]
     
        public void Message_verifyErrorMessage()
        {
            //Arrange
            NavMenu navMenu = new(driver);

            navMenu.ClickContactTab();

            //Act
            ContactPage contactPage = new ContactPage(driver);
            contactPage.ClickSubmitButton();
            wait(3);

            //Assert
            Assert.AreEqual("Message is required", contactPage.GetMessageErrorMsg());
        }

        [TestMethod]
        public void Message_verifyNoErrorMessage()
        {
            //Arrange
            NavMenu navMenu = new(driver);

            navMenu.ClickContactTab();

            //Act
            ContactPage contactPage = new ContactPage(driver);
            contactPage.FillMessage("Nice Pizza");
            wait(3);

            //Assert
            Assert.AreEqual("", contactPage.GetMessageErrorMsg());
        }
    
       
       
    }
}
