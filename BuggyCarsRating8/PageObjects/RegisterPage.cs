using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BuggyCarsRating8.PageObjects
{
    public class RegisterPage : BasePage
    {
        private IWebDriver driver;

        public RegisterPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By mainRegister = By.XPath("//a[@class='btn btn-success-outline']");
        private By regLogin = By.XPath("//input[@id='username']");
        private By regFirstName = By.Id("firstName");
        private By regLastName = By.Id("lastName");
        private By regPassword = By.Id("password");
        private By regConfirmPassword = By.Id("confirmPassword");
        private By regRegister = By.XPath("//my-register/div[@class='container my-form']/div[@class='col-md-6']/form/button");
        private By regSuccess = By.XPath("//form/div[@class='result alert alert-success']");

        public void RegisterToBuggyCarsRating(string login, string firstName, string lastName, string password, string confirmPassword)
        {
            driver.FindElement(regLogin).SendKeys(login);
            driver.FindElement(regFirstName).SendKeys(firstName);
            driver.FindElement(regLastName).SendKeys(lastName);
            driver.FindElement(regPassword).SendKeys(password);
            driver.FindElement(regConfirmPassword).SendKeys(confirmPassword); 
        }

        public void clickMainRegister()
        {
            driver.FindElement(mainRegister).Click();
        }

        public void clickRegister()
        {
            driver.FindElement(regRegister).Click();
        }
        public void checkRegistration()
        {
            Assert.IsTrue(driver.FindElement(regSuccess).Text == "Registration is successful", "Registration is successful");
        }




    }
}
