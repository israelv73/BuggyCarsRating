using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using BuggyCarsRating8.PageObjects;

namespace BuggyCarsRating8.Steps
{
    [Binding]
    public class VoteCarSteps
    {
        private IWebDriver driver;
        private OverallRatingPage overallRatingPage;
        public VoteCarSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.overallRatingPage = new OverallRatingPage(driver);
        }


        [Then(@"I can vote my favorite car")]
        public void ThenICanVoteMyFavoriteCar()
        {
            overallRatingPage.ClickCarToVote();
        }
    }
}
