using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using BuggyCarsRating8.PageObjects;

namespace BuggyCarsRating8.Steps
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginSteps(IWebDriver driver) 
        {
            this.driver = driver;
            this.loginPage = new LoginPage(driver);
        }

        [Given(@"I open the home page")]
        public void GivenIOpenTheHomePage()
        {
            loginPage.NavigateToBuggyCarsRatingPage();
        }
        
        [When(@"I login with valid Login and Password")]
        public void WhenILoginWithValidLoginAndPassword()
        {
            loginPage.LoginToBuggyCarsRating();
        }

        [Then(@"'(.*)' message is displayed")]
        public void ThenMessageIsDisplayed(string greetings)
        {
            loginPage.HiDisplayed(greetings);

        }



    }
}
