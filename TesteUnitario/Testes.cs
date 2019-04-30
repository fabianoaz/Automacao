using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TesteUnitario
{
    [TestClass]
    public class Testes
    {

        public IWebDriver driver = new ChromeDriver();
        //public IWebDriver driver = new FirefoxDriver();

        Login login =new Login();
        Medicao medicao = new Medicao();
        ConferenciaTurno conferencia = new ConferenciaTurno();

        [TestMethod]
        public void Teste()
        {
            login.CarregaPagina(driver);
            login.Logar(driver);
            medicao.AcessarMenu(driver);
            //conferencia.AcessarMenu(driver);
        }
    }
}
