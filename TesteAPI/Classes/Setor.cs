using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace TesteAPI
{
    class Setor
    {

        StringBuilder responseString = new StringBuilder();

        [TestMethod]
        public void MontarComboV1(string _Url, string _Tokenpass, string _estaCod)
        {

            string UrlApi = "/v1/Setor/MontarCombo?codigoEstabelecimento=";

            _Url = _Url + UrlApi + _estaCod;

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

        [TestMethod]
        public void MontarComboV2(string _Url, string _Tokenpass, string _cnpj)
        {

            string UrlApi = "/v2/Setor/MontarCombo?cnpjEstabelecimento=";

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
