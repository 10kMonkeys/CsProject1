using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace TestProjectCSharp.Pages
{
    class BasePage:PageObject
    {

        private readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            OpenQA.Selenium.Support.PageObjects.
            this.driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            PageFactory.InitElements(driver, this);
            

        }
    }
}
