using System.Net;
using System.Text.Json;

namespace Funciones {
    class Functions {
        static public string Solicitar(string url)
        {
            string result = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (WebResponse respuesta = request.GetResponse())
            {
                using (Stream StreamReader = respuesta.GetResponseStream())
                {
                    if (StreamReader != null)
                    {
                        using (StreamReader objReader = new StreamReader(StreamReader))
                        {
                            result = objReader.ReadToEnd();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Responde");
                    }
                }
            }
            return result;
        }
    }
}