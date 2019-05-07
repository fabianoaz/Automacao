using System;
using System.IO;
using System.Net;
using System.Text;

namespace TestAPI_Pop
    {

    public class Metodos : Geral
        {

        StringBuilder responseString = new StringBuilder();

        public void POST(string UrlApi, string _key1, string _key2, string _body, bool _printResponse)
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

            request.UserAgent = "Teste automatizado";

            var envio = Encoding.UTF8.GetBytes(_body);

            using (var stream = request.GetRequestStream())
                {
                stream.Write(envio, 0, envio.Length);
                stream.Close();
                }

            var hr = request.HaveResponse.ToString();
            if (hr != "False")
                {

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

                    if (_printResponse)
                        Console.WriteLine(UrlApi + "\n" + responseString);
                    else
                        Console.WriteLine("POST OK: " + UrlApi);

                    readStream.Close();
                    ResetUrl();
                    }
                response.Close();
                responseString.Clear();
                ResetUrl();

                }
            else
                {
                Console.WriteLine("POST ERRO: " + UrlApi + " Response vazio");
                }
            }

        public void GET(string UrlApi, string _key1, string _key2, string _key3, bool _valida, string _validacao, bool _printResponse)
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
            if (_key3 != "")
                {
                UrlBase += "&" + _key3;
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

                if (_printResponse)
                    Console.WriteLine(UrlApi + "\n" + responseString);
                else
                    Console.WriteLine("GET OK: " + UrlApi);

                if (_valida)
                    if (responseString.ToString().Contains(_validacao))
                        {
                        Console.WriteLine("Validação OK");
                        }
                    else
                        {
                        Console.WriteLine("Validação apresentou ERRO");
                        }

                readStream.Close();
                responseString.Clear();
                response.Close();
                ResetUrl();
                }
            }

        public void PUT(string UrlApi, string _key1, string _key2, string _body, bool _printResponse)
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

                if (_printResponse)
                    Console.WriteLine(UrlApi + "\n" + responseString);
                else
                    Console.WriteLine("PUT OK: " + UrlApi);

                response.Close();
                readStream.Close();
                responseString.Clear();
                ResetUrl();
                }
            }

        public void DELETE(string UrlApi, string _key1, string _key2, bool _printResponse)
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

                if (_printResponse)
                    Console.WriteLine(UrlApi + "\n" + responseString);
                else
                    Console.WriteLine("DELETE OK: " + UrlApi);

                response.Close();
                readStream.Close();
                responseString.Clear();
                ResetUrl();
                }
            }
        }

    }
