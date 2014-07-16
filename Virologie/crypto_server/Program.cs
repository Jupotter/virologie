using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Serialization;

namespace crypto_server
{
    class Program
    {
        static string getCryptoResponse()
        {
            XmlSerializer x = new XmlSerializer(typeof(PublicKeyCryptoResponse));

            CryptoResponse res = new CryptoResponse();

            var writer = new StringWriter();
            x.Serialize(writer, res.GetPublicKeyResponse());

            StreamWriter sw = new StreamWriter(new FileStream(res.guid.ToString(), FileMode.Create));
            sw.Write(res.crypto.ToXmlString(true));
            sw.Flush();
            sw.Close();

            return writer.GetStringBuilder().ToString();
        }

        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:1234/");
            listener.Start();
            Console.WriteLine("Listening...");
            while (true)
            {
                // Note: The GetContext method blocks while waiting for a request. 
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                // Obtain a response object.
                HttpListenerResponse response = context.Response;

                string responseString = getCryptoResponse();
                byte[] buffer = System.Text.Encoding.Unicode.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
            }
            listener.Stop();
        }
    }
}
