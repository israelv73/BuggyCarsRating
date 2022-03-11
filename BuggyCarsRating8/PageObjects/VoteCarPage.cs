using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BuggyCarsRating8.PageObjects
{
    public class VoteCarPage : BasePage
    {
        private IWebDriver driver;

        public VoteCarPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By voteButton = By.XPath("//button[@class='btn btn-success']");

        public void VoteCar()
        {
            driver.FindElement(voteButton).Click();
        }

    }
}
