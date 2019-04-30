using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace TesteUnitario
{
    [TestClass]
    class Medicao
    {

        [TestMethod]
        public void AcessarMenu(IWebDriver driver)
        {

            // Retorna para página inicial
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='sidebar-nav-head']")));
            driver.FindElement(By.XPath("//div[@class='sidebar-nav-head']")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementExists(By.XPath(".//nav[@class='sidebar-nav']//ul[@class='sidebar-nav-list']//li[2]/span")));

            driver.FindElement(By.XPath(".//nav[@class='sidebar-nav']//ul[@class='sidebar-nav-list']//li[2]/span")).Click();


            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='tab-diaDia']//li[3]//a")));

            driver.FindElement(By.XPath("//ul[@id='tab-diaDia']//li[3]//a")).Click();

        }
    }
}
