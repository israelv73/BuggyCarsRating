using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using BuggyCarsRating8.PageObjects;

namespace BuggyCarsRating8.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        private IWebDriver driver;
        private RegisterPage registerPage;

        public RegistrationSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.registerPage = new RegisterPage(driver);
        }

        [Given(@"I click the Register button")]
        public void GivenIClickTheRegisterButton()
        {
            registerPage.NavigateToBuggyCarsRatingPage();
            registerPage.clickMainRegister();
        }
        
        [When(@"I enter '(.*)' '(.*)' '(.*)' '(.*)' '(.*)'")]
        public void WhenIEnter(string login, string firstName, string lastName, string password, string confirmPassword)
        {
            Random rnd = new Random();

            registerPage.RegisterToBuggyCarsRating(login + rnd.Next(), firstName, lastName + rnd.Next(), password, confirmPassword);
        }
        
        [When(@"click Register button")]
        public void WhenClickRegisterButton()
        {
            registerPage.clickRegister();
        }
        
        [Then(@"new user is registered")]
        public void ThenNewUserIsRegistered()
        {
            registerPage.checkRegistration();
        }
    }
}
