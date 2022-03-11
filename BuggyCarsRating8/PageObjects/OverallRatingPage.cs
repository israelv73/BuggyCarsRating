using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BuggyCarsRating8.PageObjects
{
    public class OverallRatingPage : BasePage
    {
        private IWebDriver driver;

        public OverallRatingPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By overallRatingLink = By.XPath("//div[@class='col-md-4'][3]/div[@class='card']/a");
        private By overallRatingMakeTable = By.XPath("//tbody/tr/td[2]");
        private By overallRatingModelTable = By.XPath("//tbody/tr/td[3]");
        
        public void ClickOverallRating()
        {
            driver.FindElement(overallRatingLink).Click();
        }

        public void ListOverallTopFiveCars()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(driver.FindElements(overallRatingMakeTable)[i].Text + " " + driver.FindElements(overallRatingModelTable)[i].Text);
            }
        }
    }
}
