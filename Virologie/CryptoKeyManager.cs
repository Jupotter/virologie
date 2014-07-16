using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.IO;

namespace Virologie
{
    class CryptoKeyManager
    {
        public static FileEncrypter CreateFromServer(string address)
        {
            XmlSerializer x = new XmlSerializer(typeof(PublicKeyCryptoResponse));

            var request = WebRequest.Create(address);
            var response = request.GetResponse();

            PublicKeyCryptoResponse pkres = (PublicKeyCryptoResponse)x.Deserialize(response.GetResponseStream());
            FileEncrypter ret = new FileEncrypter();
            ret.ImportKey(pkres.public_key);
            return ret;
        }

        public static FileEncrypter CreateFromFile(string name)
        {
            StreamReader sr = new StreamReader(new FileStream(name, FileMode.Open));
            string private_key = sr.ReadToEnd();
            FileEncrypter ret = new FileEncrypter();
            ret.ImportKey(private_key);
            return ret;
        }
    }
}
