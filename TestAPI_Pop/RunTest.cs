using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteAPI_Pop;

namespace TestAPI_Pop
{
    [TestClass]
    public class RunTest : Testes 
    {
        UnidadeFederativa UF = new UnidadeFederativa();
        FormasPagamento FPAG = new FormasPagamento();
        // Geral geral = new Geral(); -- Classe Geral é herdada na classe Teste
       // Testes testes = new Testes(); -- Classe Teste é herdada na classe RunTest

        [TestMethod]
        public void Run()
        {
            
            POST(FPAG.POST_Listar_v1, Url, Tokenpass, "", "", FPAG.POST_Listar_v1_Body);

            // Selecionar da API de Formas de pagamentto está com erro
            // GET(FPAG.GET_Selecionar_v1, Url, Tokenpass, CodigoEstabelecimento, CodigoFormaPagamento);

            GET(FPAG.GET_MontarCombo_v1, Url, Tokenpass, cnpjEstabelecimento,"");

            POST(FPAG.POST_Incluir_v1, Url, Tokenpass, "", "", FPAG.POST_Incluir_v1_Body);
            
            PUT(FPAG.PUT_Alterar_v1, Url, Tokenpass, "", "", FPAG.PUT_Alterar_v1_Body);
            
            DELETE(FPAG.DEL_Excluir_v1, Url, Tokenpass, cnpjEstabelecimento, CodigoFormaPagamento);
            
        }
    }
}
