using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAPI_Pop
{
    [TestClass]
    public class RunTest : Metodos
    {
        Apis api = new Apis();

        [TestMethod]
        public void Pessoa()
        {
            POST(api.POST_Pessoa_Incluir_v1, "", "", CarregaJson(@"..\..\JSONs\Pessoa\Pessoa_Incluir_v1.json"),false);

            GET(api.GET_Pessoa_MontarCombo_v1, cnpjEstabelecimento,"classificacaoPessoa=3", "codigoCategoria=0", false, "Pessoa Incluída Via Automacao de Teste", false);

            POST(api.POST_Pessoa_Listar_v1, "", "", CarregaJson(@"..\..\JSONs\Pessoa\Pessoa_Listar_v1.json"), false);
        }

        [TestMethod]
        public void AgrupadorCliente()
        {

        //  POST(api.POST_AgrupadorCliente_Incluir_v1, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Incluir_v1.json"),false);

        //  POST(api.POST_AgrupadorCliente_Listar_v1, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Listar_v1.json"),false);

            GET(api.GET_AgrupadorCliente_Selecionar_v1, CodigoEstabelecimento, CodigoAgrupador, "", true, "Inserido via Automacao API", false);

        //  Ajustar arquivo JSON
        //  PUT(api.PUT_AgrupadorCliente_Alterar_v1, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Alterar_v1.json"));

        //  Ajustar cpodigo do agrpador a ser deletado ou informar "codigoAgrupador = XX"
        //  DELETE(api.DEL_AgrupadorCliente_Excluir_v1, CodigoEstabelecimento, CodigoAgrupador);

        }

        [TestMethod]
        public void Almoxarifado()
        {
            GET(api.Almoxarifado_Listar_v1,CodigoEstabelecimento, "", "", true, "Pista", false);
            //    GET(api.Almoxarifado_Selecionar_v1, "", "", false, "", false);
            //    POST(api.Almoxarifado_Incluir_v1, "", "", CarregaJson(@"..\..\JSONs\Almoxarifado\Almoxarifado_Incluir_v1.json"),false);
            //    PUT(api.Almoxarifado_Alterar_v1, "", "", CarregaJson(@"..\..\JSONs\Almoxarifado\Almoxarifado_Alterar_v1.json"));
            //    DELETE(api.Almoxarifado_Excluir_v1, CodigoEstabelecimento, "codigoAlmoxarifado=2");
            //    GET(api.Almoxarifado_Restaurar_v1, CodigoEstabelecimento, "codigoAlmoxarifado=2", false, "", false);
            //    GET(api.Almoxarifado_MontarCombo_v1, CodigoEstabelecimento, "tipo=", false, "", false);
            //    GET(api.Almoxarifado_MontarCombo_v1, cnpjEstabelecimento, "tipos=1,2,3", false, "", false);
        }

        [TestMethod]
        public void UnidadeFederativa()
        {
            GET(api.UnidadeFederativa_MontarComboUF_v1, "", "", "", true, "{\"codigo\":43,\"descricao\":\"RS\"}",false);
        }

        [TestMethod]
        public void FormasPagamento()
        {
            //    POST(api.FormasPagamento_Listar_v1, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Listar_v1_Body.json"),false);

            // Selecionar da API de Formas de pagamentto está com erro
            // GET(api.FormasPagamento_GET_Selecionar_v1, Url, Tokenpass, CodigoEstabelecimento, CodigoFormaPagamento);

            GET(api.FormasPagamento_MontarCombo_v1, cnpjEstabelecimento, "", "", true, "Dinheiro", false);

            //    POST(api.FormasPagamento_Incluir_v1, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Incluir_v1_Body.json"),false);

            //    PUT(api.FormasPagamento_Alterar_v1, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Alterar_v1_Body.json"));

            //    DELETE(api.FormasPagamento_Excluir_v1, cnpjEstabelecimento, CodigoFormaPagamento);
        }

    }
}
