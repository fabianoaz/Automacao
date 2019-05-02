using System;
using System.IO;
using System.Net;
using System.Text;

namespace TestAPI_Pop
    {

    public class Metodos : Geral
        {
        
        StringBuilder responseString = new StringBuilder();

        public void POST(string UrlApi, string _key1, string _key2, string _body)
            {

            UrlBase = UrlBase + UrlApi;

            if (_key1 != "")
                {
                UrlBase += _key1;
                }
            if (_key2 != "")
                {
                UrlBase += "&" + _key2;
                }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(UrlBase);

            request.Method = "POST";

            request.ContentType = "application/json";

            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers.Set("Tokenpass", Tokenpass);

            var envio = Encoding.UTF8.GetBytes(_body);

            using (var stream = request.GetRequestStream())
                {
                stream.Write(envio, 0, envio.Length);
                stream.Close();
                }

            var response = request.GetResponse();
            Stream receiveStream = null;

            try
                {
                receiveStream = response.GetResponseStream();
                }
            catch
                {
                Console.WriteLine("Ocorreu erro ao receber resposta");
                }
           

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
                responseString.Clear();
                }
            }

        public void GET(string UrlApi, string _key1, string _key2)
            {
            UrlBase = UrlBase + UrlApi;

            if (_key1 != "")
                {
                UrlBase += _key1;
                }
            if (_key2 != "")
                {
                UrlBase += "&" + _key2;
                }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(UrlBase);

            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers.Set("Tokenpass", Tokenpass);

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
                responseString.Clear();
                }
            }

        public void PUT(string UrlApi, string _key1, string _key2, string _body)
            {
            UrlBase = UrlBase + UrlApi;

            if (_key1 != "")
                {
                UrlBase += _key1;
                }
            if (_key2 != "")
                {
                UrlBase += "&" + _key2;
                }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(UrlBase);

            request.Method = "PUT";

            request.ContentType = "application/json";

            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers.Set("Tokenpass", Tokenpass);

            var envio = Encoding.UTF8.GetBytes(_body);

            using (var stream = request.GetRequestStream())
                {
                stream.Write(envio, 0, envio.Length);
                stream.Close();
                }

            var response = request.GetResponse();

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
                responseString.Clear();
                }
            }

        public void DELETE(string UrlApi, string _key1, string _key2)
            {
            UrlBase = UrlBase + UrlApi;

            if (_key1 != "")
                {
                UrlBase += _key1;
                }
            if (_key2 != "")
                {
                UrlBase += "&" + _key2;
                }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(UrlBase);

            request.Credentials = CredentialCache.DefaultCredentials;

            request.Method = "DELETE";

            request.Headers.Set("Tokenpass", Tokenpass);

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
                responseString.Clear();
                }
            }
        }

    }
