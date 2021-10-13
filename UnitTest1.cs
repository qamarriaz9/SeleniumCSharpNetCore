using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}