using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using BuggyCarsRating8.PageObjects;


namespace BuggyCarsRating8.Steps
{
    [Binding]
    public class PopularMakeSteps
    {
        private IWebDriver driver;
        private PopularMakePage popularMakePage;
        public PopularMakeSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.popularMakePage = new PopularMakePage(driver);
        }


        [When(@"I click Popular Make")]
        public void WhenIClickPopularMake()
        {
            popularMakePage.ClickPopularMake();
        }
        
        [Then(@"the Top Five models of the Popular Make are displayed")]
        public void ThenTheTopFiveModelsOfThePopularMakeAreDisplayed()
        {
            popularMakePage.ListTopFiveModelofPopularMake();
        }


    }
}
