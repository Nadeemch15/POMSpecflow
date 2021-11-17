using NUnit.Framework;
using OpenQA.Selenium;
using POMSpecflow.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMSpecflow.PageObject
{
    class CreateAccountPage
    {
        IWebDriver driver;
        public CreateAccountPage()
        {
            driver = Hook.driver;
        }

        #region Locators

        public IWebElement EnterEmail => Hook.driver.FindElement(By.XPath("//input[@id='email_create']"));
        public IWebElement CreateBtn => Hook.driver.FindElement(By.Id("SubmitCreate"));
        public IWebElement PageHeading => Hook.driver.FindElement(By.ClassName("page-heading"));

        #endregion

        #region Actions

        public void NavigateToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }
        public void Email()
        {
            EnterEmail.SendKeys("teat@abc.com");

        }
        public void Createbtn()
        {
            CreateBtn.Click();
        }
        public void PageHead()
        {
            Assert.AreEqual("AUTHENTICATION", PageHeading.Text);

        }

        #endregion


    }
}
