using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BuggyCarsRating8.PageObjects
{
    public class PopularModelPage : BasePage
    {
        private IWebDriver driver;

        public PopularModelPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By popularModelLink = By.XPath("//div[@class='col-md-4'][2]/div[@class='card']/a");
        private By popularModelCar = By.XPath("//div[@class='row'][1]/div[@class='col-lg-2']/div[@class='card-block text-xs-center'][2]/h4");

        public void ClickPopularModel()
        {
            driver.FindElement(popularModelLink).Click();
        }

        public void ListPopularModel()
        {
            Console.WriteLine(driver.FindElement(popularModelCar).Text);
        }

    }
}
