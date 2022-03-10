using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BuggyCarsRating8.PageObjects
{
    public class PopularMakePage : BasePage
    {
        private IWebDriver driver;

        public PopularMakePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By popularMakeLink = By.XPath("//div[@class='col-md-4'][1]/div[@class='card']/a");
        private By popularMakeTable = By.XPath("//tbody//td[2]");


        public void ClickPopularMake()
        {
            driver.FindElement(popularMakeLink).Click();
        }

        public void ListTopFiveModelofPopularMake()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(driver.FindElements(popularMakeTable)[i].Text);
            }                       
        }
    }
}
