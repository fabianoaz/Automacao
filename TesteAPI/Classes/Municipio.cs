using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace TesteAPI
{
    class Municipio
    {
        StringBuilder responseString = new StringBuilder();

        [TestMethod]
        public void MontarComboCidades(string _Url, string _Tokenpass, string _codigoUF)
        {

           string UrlApi = "/v1/Municipio/MontarComboCidades?codigoUF=";

            _Url = _Url + UrlApi + _codigoUF;

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

                /*
                string jsonteste = JsonConvert.SerializeObject(responseString);
                Console.WriteLine(jsonteste);
                */

                response.Close();
                readStream.Close();
            }
        }

    }
}
