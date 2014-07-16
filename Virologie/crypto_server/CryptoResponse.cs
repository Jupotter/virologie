using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace crypto_server
{
    public class CryptoResponse
    {
        public RSACryptoServiceProvider crypto;
        public Guid guid;

        public CryptoResponse()
        {
            crypto = new RSACryptoServiceProvider(2048);
            guid = Guid.NewGuid();
        }

        public PublicKeyCryptoResponse GetPublicKeyResponse()
        {
            return new PublicKeyCryptoResponse
            {
                public_key = crypto.ToXmlString(false),
                guid = guid,
            };
        }
    }

    public struct PublicKeyCryptoResponse
    {
        public string public_key;
        public Guid guid;
    }
}
