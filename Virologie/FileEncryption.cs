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
        private RSACryptoServiceProvider _algorithm_asym;

        public FileEncrypter()
        {
            _algorithm_asym = new RSACryptoServiceProvider();

            _algorithm_asym.PersistKeyInCsp = false;
        }

        public bool CanDecrypt()
        {
            return _algorithm_asym.PublicOnly;
        }

        public void Decrypt(string filename)
        {
            FileStream fsInput = new FileStream(filename, FileMode.Open, FileAccess.Read);
            FileStream fsOutput = new FileStream(filename + ".crypt", FileMode.Create, FileAccess.Write);
            AesCryptoServiceProvider Aes = new AesCryptoServiceProvider();

            Aes.KeySize = 128;

            byte[] input = new byte[256];

            int count = fsInput.Read(input, 0, 256);
            Aes.Key = _algorithm_asym.Decrypt(input, false);
            count = fsInput.Read(input, 0, 256);
            Aes.IV = _algorithm_asym.Decrypt(input, false);

            ICryptoTransform desencrypt = Aes.CreateDecryptor();
            CryptoStream cryptostream = new CryptoStream(fsOutput, desencrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fsInput.Length - 1];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);

            fsInput.Close();
            fsOutput.Close();
        }

        public void Encrypt(string filename)
        {
            FileStream fsInput = new FileStream(filename, FileMode.Open, FileAccess.Read);
            FileStream fsOutput = new FileStream(filename + ".crypt", FileMode.Create, FileAccess.Write);
            AesCryptoServiceProvider Aes = new AesCryptoServiceProvider();

            Aes.KeySize = 128;
            Aes.GenerateIV();
            Aes.GenerateKey();

            byte[] output = _algorithm_asym.Encrypt(Aes.Key, false);
            fsOutput.Write(output, 0, 256);
            output = _algorithm_asym.Encrypt(Aes.IV, false);
            fsOutput.Write(output, 0, 256);

            ICryptoTransform encrypt = Aes.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsOutput, encrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fsInput.Length - 1];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);

            fsInput.Close();
            fsOutput.Close();
        }

        public string DumpKey()
        {
            return _algorithm_asym.ToXmlString(false);
        }

        public void ImportKey(String key)
        {
            _algorithm_asym.FromXmlString(key);
        }
    }
}
