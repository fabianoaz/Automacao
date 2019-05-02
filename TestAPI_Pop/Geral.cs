using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Runtime.Serialization.Json;
using System.Reflection;

namespace TestAPI_Pop
    {
    public class Geral
        {

        public string UrlBase = "http://qa-postopop.inovapostos.com.br/LxApi";
        public string Tokenpass = "491E26F7-E1D7-4B53-9324-C28C80B41821";
        public string cnpjEstabelecimento = "cnpjEstabelecimento=17898787000153";
        public string CNPJ = "CNPJ=17898787000153";
        public string CodigoEmpresa = "CodigoEmpresa=1";
        public string CodigoEstabelecimento = "CodigoEstabelecimento=1";
        public string CodigoFormaPagamento = "CodigoFormaPagamento=11";
        public string CodigoAgrupador = "codigoAgrupador = 1";
        public string ContentType = "application/json";

        public static string CarregaJson(string arquivo)
            {

            string completo = Path.GetFullPath(arquivo);

            using (StreamReader r = new StreamReader(completo))
                {

                string json = r.ReadToEnd();

                return json;

                }
            }
        }
    }
