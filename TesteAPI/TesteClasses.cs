using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteAPI.Classes;

namespace TesteAPI
{
    [TestClass]
    public class TesteClasses
    {
        UnidadeFederativa uf = new UnidadeFederativa();
        Municipio muni = new Municipio();
        Setor setor = new Setor();
        FormasPagamento fpag = new FormasPagamento();

        private string Url = "http://qa-postopop.inovapostos.com.br/LxApi";
        private string Tokenpass = "491E26F7-E1D7-4B53-9324-C28C80B41821";

        [TestMethod]
        public void Teste()
        {
            muni.MontarComboCidades(Url, Tokenpass, "51");
            /*
            uf.MontarComboUF(Url, Tokenpass);
            setor.MontarComboV1(Url, Tokenpass, "1");
            setor.MontarComboV2(Url, Tokenpass, "17898787000153");
            fpag.MontarCombo(Url, Tokenpass, "17898787000153");
            */
        }
    }
}
