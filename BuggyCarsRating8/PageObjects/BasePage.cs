using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BuggyCarsRating8.PageObjects
{
    public class BasePage
    {
        private IWebDriver driver;
        protected string username = "QATest1";
        protected string password = "P@ssw0rd!";
        private string BuggyCarsRatingURL = "https://buggy.justtestit.org/";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToBuggyCarsRatingPage()
        {
            driver.Navigate().GoToUrl(BuggyCarsRatingURL);
        }

    }
}
