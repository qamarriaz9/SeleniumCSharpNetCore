using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup method");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            // CustomControl.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Mango");
            // CustomControl.ClickButton(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));

            CustomControl.SelectByText(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");
            //CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Assert.Pass();
        }
        [Test]
        public void LoginTest()
        {
            //driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            //HomePage home = new HomePage();
            //LoginPage loginPage = new LoginPage();

            //home.ClickLogin();
            //loginPage.EnterUserNameAndPassword("admin", "password");
            //loginPage.ClickLoginButton();

            //Console.WriteLine("LoginTest method");
            //Assert.That(home.IsLogOffExist(), Is.True, "Log off did not Displayed");
            //Console.WriteLine("LoginTest method");

        }
    }
}