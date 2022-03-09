using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BuggyCarsRating8.PageObjects
{
    public class LoginPage : BasePage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By LoginField = By.XPath("//input");
        private By PasswordField = By.XPath("//input");
        private By LoginButton = By.XPath("//button[@class='btn btn-success']");
        private By HiText = By.XPath("//li[@class='nav-item'][1]/span");

        public void LoginToBuggyCarsRating()
        {
            driver.FindElements(LoginField)[0].SendKeys(username);
            driver.FindElements(PasswordField)[1].SendKeys(password);
            driver.FindElement(LoginButton).Click();
        }

        public void HiDisplayed(string greetings)
        {
            string GreetingText = driver.FindElement(HiText).Text;
            Assert.IsTrue(GreetingText.StartsWith(greetings),"Expected " + greetings + " , Actual: " + GreetingText);
        }

        
    }
}