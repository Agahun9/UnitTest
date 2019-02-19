using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Support.UI;

namespace LoginTest
{
    [TestFixture]
    public class LoginTest
    {

        IWebDriver _driver;
        private readonly string login = "agahun";
        private readonly string pass = "q1w2e3";
        private readonly string pass1 = "q1w";

        [SetUp]
        public void StartBrowser()
        {
            _driver = new FirefoxDriver();
        }

        [Test]
        public void loginTestPassed()
        {
            _driver.Navigate().GoToUrl("http://www.subway.c0.pl");
            var loginBox = _driver.FindElement(By.Name("login"));
            var passwordBox = _driver.FindElement(By.Name("password"));
            var loginbutton = _driver.FindElement(By.CssSelector(".btn"));
            loginBox.SendKeys(login);
            passwordBox.SendKeys(pass);
            loginbutton.Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists((By.ClassName("bok"))));

            Assert.AreEqual("Witaj " + login, _driver.FindElement(By.ClassName("bok")).Text);
        }

        [Test]
        public void BadLoginOrPasswordTestPassed()
        {
            _driver.Navigate().GoToUrl("http://www.subway.c0.pl");
            var loginBox = _driver.FindElement(By.Name("login"));
            var passwordBox = _driver.FindElement(By.Name("password"));
            var loginbutton = _driver.FindElement(By.CssSelector(".btn"));
            loginBox.SendKeys(login);
            passwordBox.SendKeys(pass1);
            loginbutton.Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists((By.Id("badlogin"))));

            Assert.AreEqual("Nieprawidłowe hasło lub login", _driver.FindElement(By.Id("badlogin")).Text);


        }
    }
}
