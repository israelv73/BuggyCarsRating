using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using BuggyCarsRating8.PageObjects;

namespace BuggyCarsRating8.Steps
{
    [Binding]
    public class OverallRatingSteps
    {
        private IWebDriver driver;
        private OverallRatingPage overallRatingPage;
        public OverallRatingSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.overallRatingPage = new OverallRatingPage(driver);
        }


        [When(@"I click Overall Rating")]
        public void WhenIClickOverallRating()
        {
            overallRatingPage.ClickOverallRating();
        }
        
        [Then(@"the Overall Top Five Cars are displayed")]
        public void ThenTheOverallTopFiveCarsAreDisplayed()
        {
            overallRatingPage.ListOverallTopFiveCars();
        }
    }
}
