using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace TesteAPI.Classes
{
    class FormasPagamento
    {

        StringBuilder responseString = new StringBuilder();

        [TestMethod]
        public void MontarCombo(string _Url, string _Tokenpass, string _cnpj)
        {

            string UrlApi = "/v1/FormasPagamento/MontarCombo?cnpjEstabelecimento=";

            _Url = _Url + UrlApi + _cnpj;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_Url);

            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers.Set("Tokenpass", _Tokenpass);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();

            if (receiveStream != null)
            {
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string line = "";
                while ((line = readStream.ReadLine()) != null)
                {
                    responseString.Append(line);
                }
                Console.WriteLine(responseString);

                response.Close();
                readStream.Close();
            }
        }
    }
}
