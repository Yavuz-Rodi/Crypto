using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;


namespace Yavuz_Rodi_crypto
{
    class cryptonet
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(512);
        private RSAParameters prv_key;
        private RSAParameters publ_key;

        public cryptonet()
        {
            prv_key = csp.ExportParameters(true);
            publ_key = csp.ExportParameters(false);
        }
        public string Key_Pub()
        {
            var s = new StringWriter();
            var x = new XmlSerializer(typeof(RSAParameters));
            x.Serialize(s, publ_key);
            return s.ToString();
        }
        public string Crypter(string mess)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(publ_key);

            var Data = Encoding.Unicode.GetBytes(mess);
            var chiffrement = csp.Encrypt(Data, false);
            return Convert.ToBase64String(chiffrement);
        }
        public string Decrypter(string mess_chiffrement)
        {
            var byte_Data = Convert.FromBase64String(mess_chiffrement);
            csp.ImportParameters(prv_key);
            var mess = csp.Decrypt(byte_Data, false);
            return Encoding.Unicode.GetString(mess);
        }
    }

}
