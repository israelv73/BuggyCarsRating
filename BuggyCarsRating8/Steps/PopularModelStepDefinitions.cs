using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using BuggyCarsRating8.PageObjects;

namespace BuggyCarsRating8.Steps
{
    [Binding]
    public class PopularModelSteps
    {
        private IWebDriver driver;
        private PopularModelPage popularModelPage;

        public PopularModelSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.popularModelPage = new PopularModelPage(driver);
        }

        [When(@"I click Popular Model")]
        public void WhenIClickPopularModel()
        {
            popularModelPage.ClickPopularModel();
        }
        
        [Then(@"the top Model is displayed")]
        public void ThenTheTopModelIsDisplayed()
        {
            popularModelPage.ListPopularModel();
        }



    }
}
