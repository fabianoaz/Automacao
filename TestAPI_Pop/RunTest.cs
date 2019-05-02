using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAPI_Pop
{
    [TestClass]
    public class RunTest : Metodos
    {
        Apis api = new Apis();

        [TestMethod]
        public void AgrupadorCliente()
        {

            POST(api.AgrupadorCliente_Listar_v1, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Listar_v1.json"));

            GET(api.AgrupadorCliente_Selecionar_v1, CodigoEstabelecimento, CodigoAgrupador);

            POST(api.AgrupadorCliente_Incluir_v1, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Incluir_v1.json"));

            // Ajustar arquivo JSON
            PUT(api.AgrupadorCliente_Alterar_v1, "", "", CarregaJson(@"..\..\JSONs\AgrupadorCliente\AgrupadorCliente_Alterar_v1.json"));

            // Ajustar cpodigo do agrpador a ser deletado ou informar "codigoAgrupador = XX"
            DELETE(api.AgrupadorCliente_Excluir_v1, CodigoEstabelecimento, CodigoAgrupador);

        }

        [TestMethod]
        public void Almoxarifado()
        {
            GET(api.Almoxarifado_Listar_v1, "", "");
            GET(api.Almoxarifado_Selecionar_v1, "", "");
            POST(api.Almoxarifado_Incluir_v1, "", "", CarregaJson(@"..\..\JSONs\Almoxarifado\Almoxarifado_Incluir_v1.json"));
            PUT(api.Almoxarifado_Alterar_v1, "", "", CarregaJson(@"..\..\JSONs\Almoxarifado\Almoxarifado_Alterar_v1.json"));
            DELETE(api.Almoxarifado_Excluir_v1, CodigoEstabelecimento, "codigoAlmoxarifado=2");
            GET(api.Almoxarifado_Restaurar_v1, CodigoEstabelecimento, "codigoAlmoxarifado=2");
            GET(api.Almoxarifado_MontarCombo_v1, CodigoEstabelecimento, "tipo=");
            GET(api.Almoxarifado_MontarCombo_v1, cnpjEstabelecimento, "tipos=1,2,3");
        }

        [TestMethod]
        public void UnidadeFederativa()
        {
            GET(api.UnidadeFederativa_MontarComboUF_v1, "", "");
        }

        [TestMethod]
        public void FormasPagamento()
        {
            POST(api.FormasPagamento_Listar_v1, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Listar_v1_Body.json"));

            // Selecionar da API de Formas de pagamentto está com erro
            // GET(api.FormasPagamento_GET_Selecionar_v1, Url, Tokenpass, CodigoEstabelecimento, CodigoFormaPagamento);

            GET(api.FormasPagamento_MontarCombo_v1, cnpjEstabelecimento, "");

            POST(api.FormasPagamento_Incluir_v1, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Incluir_v1_Body.json"));

            PUT(api.FormasPagamento_Alterar_v1, "", "", CarregaJson(@"..\..\JSONs\FormasPagamento\FormasPagamento_Alterar_v1_Body.json"));

            DELETE(api.FormasPagamento_Excluir_v1, cnpjEstabelecimento, CodigoFormaPagamento);
        }

    }
}
