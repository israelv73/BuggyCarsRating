using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Edge.SeleniumTools;
using BoDi;

namespace BuggyCarsRating8.Hooks
{
    [Binding]
    class WebdriverHooks
    {
        private readonly IObjectContainer container;
        private string browser;
        private IWebDriver driver;

        public WebdriverHooks(IObjectContainer container)
        {
            this.container = container;
            browser = "chrome";
        }

        [BeforeScenario]
        public void CreateWebDriver()
        {
            switch(browser)
            {
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();

                    chromeOptions.AddArgument("start-maximized");
                    driver = new ChromeDriver(chromeOptions);
                    driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(5));
                    container.RegisterInstanceAs<IWebDriver>(driver);
                    break;
            }
        }

        [AfterScenario]
        public void DestroyWebDriver()
        {
            var driver = container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }


    }
}
