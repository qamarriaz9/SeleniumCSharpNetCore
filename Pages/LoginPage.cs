using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement txtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUserNameAndPassword(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
        }
        public void ClickLoginButton()
        {
            btnLogin.Click();
        }
      
    }
}
