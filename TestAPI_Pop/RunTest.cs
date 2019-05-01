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

            #region AgrupadorCliente

            POST(api.AgrupadorCliente_Listar_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Listar_v1.json"));

            GET(api.AgrupadorCliente_Selecionar_v1, Url, Tokenpass, CodigoEstabelecimento, CodigoAgrupador);

            POST(api.AgrupadorCliente_Incluir_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Incluir_v1.json"));

            // Ajustar arquivo JSON
            PUT(api.AgrupadorCliente_Alterar_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Alterar_v1.json"));

            // Ajustar cpodigo do agrpador a ser deletado ou informar "codigoAgrupador = XX"
            DELETE(api.AgrupadorCliente_Excluir_v1, Url, Tokenpass, CodigoEstabelecimento, CodigoAgrupador);

            #endregion

            #region Almoxarifado
            GET(api.Almoxarifado_Listar_v1, Url, Tokenpass, "", "");
            GET(api.Almoxarifado_Selecionar_v1, Url, Tokenpass, "", "");
            POST(api.Almoxarifado_Incluir_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\Almoxarifado\Almoxarifado_Incluir_v1.json"));
            PUT(api.Almoxarifado_Alterar_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\Almoxarifado\Almoxarifado_Alterar_v1.json"));
            DELETE(api.Almoxarifado_Excluir_v1, Url, Tokenpass, CodigoEstabelecimento, "codigoAlmoxarifado=2");
            GET(api.Almoxarifado_Restaurar_v1, Url, Tokenpass, CodigoEstabelecimento, "codigoAlmoxarifado=2");
            GET(api.Almoxarifado_MontarCombo_v1, Url, Tokenpass, CodigoEstabelecimento, "tipo=");
            GET(api.Almoxarifado_MontarCombo_v1, Url, Tokenpass, cnpjEstabelecimento, "tipos=1,2,3");
            #endregion

            #region UnidadeFederativa

            GET(api.UnidadeFederativa_MontarComboUF_v1, Url, Tokenpass, "", "");

            #endregion

            #region FormasPagamento

            POST(api.FormasPagamento_Listar_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Listar_v1_Body.json"));

            // Selecionar da API de Formas de pagamentto está com erro
            // GET(api.FormasPagamento_GET_Selecionar_v1, Url, Tokenpass, CodigoEstabelecimento, CodigoFormaPagamento);

            GET(api.FormasPagamento_MontarCombo_v1, Url, Tokenpass, cnpjEstabelecimento, "");

            POST(api.FormasPagamento_Incluir_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Incluir_v1_Body.json"));

            PUT(api.FormasPagamento_Alterar_v1, Url, Tokenpass, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Alterar_v1_Body.json"));

            DELETE(api.FormasPagamento_Excluir_v1, Url, Tokenpass, cnpjEstabelecimento, CodigoFormaPagamento);

            #endregion

            }
        }
    }
