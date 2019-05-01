using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAPI_Pop
    {
    [TestClass]
    public class RunTest : Metodos
        {
        Apis api = new Apis();
        // Geral geral = new Geral(); -- Classe Geral é herdada na classe Teste
        // Testes testes = new Testes(); -- Classe Teste é herdada na classe RunTest

        [TestMethod]
        public void Run()
            {

        #region Unidade Federativa

            GET(api.UnidadeFederativa_MontarComboUF_v1, Url, Tokenpass, "", "");

        #endregion

        #region Formas de Pagamento

            POST(api.FormasPagamento_Listar_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento_Listar_v1_Body.json"));

            // Selecionar da API de Formas de pagamentto está com erro
            // GET(api.FormasPagamento_GET_Selecionar_v1, Url, Tokenpass, CodigoEstabelecimento, CodigoFormaPagamento);

            GET(api.FormasPagamento_MontarCombo_v1, Url, Tokenpass, cnpjEstabelecimento, "");

            POST(api.FormasPagamento_Incluir_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento_Incluir_v1_Body.json"));

            PUT(api.FormasPagamento_Alterar_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento_Alterar_v1_Body.json"));

            DELETE(api.FormasPagamento_Excluir_v1, Url, Tokenpass, cnpjEstabelecimento, CodigoFormaPagamento);
            
        #endregion
            }
        }
    }
