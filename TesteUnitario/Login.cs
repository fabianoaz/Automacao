using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TesteUnitario
{
    [TestClass]
    class Login
    {


        [TestMethod]
        public void CarregaPagina(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://qa-postopop.azurewebsites.net");

            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementExists(By.Name("CNPJ")));

            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void Logar(IWebDriver driver)
        {

            driver.FindElement(By.Name("CNPJ")).SendKeys("17898787000153");

            driver.FindElement(By.Id("bt-entrar")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.Name("user")));

            driver.FindElement(By.Name("user")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("1");

            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(By.Id("bt-entrar")));

            driver.FindElement(By.Id("bt-entrar")).Click();

        }

    }
}
