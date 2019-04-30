using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace TesteAPI_Pop
{
    class UnidadeFederativa
    {
       public string GET_MontarCombo_v1 = "/v1/UnidadeFederativa/MontarComboUF";
    }

    class FormasPagamento
    {
        public string POST_Listar_v1 = "/v1/FormasPagamento/Listar";

        public string POST_Listar_v1_Body = "{'query':" +
                                                "{" +
                                                    "'cnpjEstabelecimento': '17898787000153'," +
                                                    "'somenteAtivos': true," +
                                                    "'cadastroCompleto': false" +
                                                "}," +
                                                    "'pagination':{" +
                                                        "'page': 0,'pagesize': 20" +
                                                     "}" +
                                               "}";

        public string GET_Selecionar_v1 = "/v1/FormasPagamento/Selecionar?";

        public string GET_MontarCombo_v1 = "/v1/FormasPagamento/MontarCombo?";

        public string POST_Incluir_v1 = "/v1/FormasPagamento/Incluir";

        public string POST_Incluir_v1_Body = "{'cnpjEstabelecimento': '17898787000153'," +
                                                "'descricao': 'FORMA PGTO VIA API'," +
                                                "'tipo': {'codigo': 3}," +
                                                "'avisoSangria': false," +
                                                "'interna': true," +
                                                "'opcoesPagamento': {'codigo': 1}," +
                                                "'parcelamento': {" +
                                                    "'numeroParcelas': 1," +
                                                    "'carenciaPrimeiraParcela': 0," +
                                                    "'primeiraParcelaMaior': false," +
                                                    "'periodicidade': 0," +
                                                    "'diasCorridos': false," +
                                                    "'juros': 0}," +
                                                "'inativo': false," +
                                                "'diaRecebimento' : 0}";

        public string PUT_Alterar_v1 = "/v1/FormasPagamento/Alterar";

        public string PUT_Alterar_v1_Body = "{'cnpjEstabelecimento': '17898787000153'," +
                                                "'codigo': -11," +
                                                "'descricao': 'ERA PREMMIA - VI API'," +
                                                "'tipo': {'codigo': 11}," +
                                                "'avisoSangria': false," +
                                                "'interna': true," +
                                                "'opcoesPagamento': {'codigo': 1}," +
                                                "'parcelamento': {" +
                                                    "'numeroParcelas': 1," +
                                                    "'carenciaPrimeiraParcela': 0," +
                                                    "'primeiraParcelaMaior': false," +
                                                    "'periodicidade': 0," +
                                                    "'diasCorridos': false," +
                                                    "'juros': 0}," +
                                                "'inativo': false," +
                                                "'diaRecebimento': 1," +
                                                "'rowVersion': 'AAAAAAATG0w='}";

        public string DEL_Excluir_v1 = "/v1/FormasPagamento/Excluir?";
    }
}
