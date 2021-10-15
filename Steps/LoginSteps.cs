using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class LoginSteps
    {

        private DriverHelper _driverHelper;
        HomePage home;
        LoginPage loginPage;
        public LoginSteps(DriverHelper driverhelper)
        {
            _driverHelper = driverhelper;
             home = new HomePage(_driverHelper.driver);
             loginPage = new LoginPage(_driverHelper.driver);
        }

        [Given(@"I navigate to Application")]
        public void GivenINavigateToApplication()
        {
            _driverHelper.driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            home.ClickLogin();
        }


        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginPage.EnterUserNameAndPassword(data.UserName, data.Password);
            
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.That(home.IsLogOffExist(), Is.True, "Log off did not Displayed");
        }




    }
}
