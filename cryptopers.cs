using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yavuz_Rodi_crypto
{
    class cryptopers
    {
        private string key;
        public string cryptkey
        {
            get { return key; }
        }
        public cryptopers(string cle)
        {
            key = cle;

        }
        public string Crypter(string j)
        {
            string crypter = null;

            for (int i = 0; i < j.Length; i++)
            {
                crypter += Convert.ToString(Convert.ToChar((Convert.ToInt16(key[i % key.Length]) + Convert.ToInt16(j[i])) % 676));
            }

            return crypter;
        }
        public string Decrypter(string d)
        {
            string decrypter = null;

            for (int i = 0; i < d.Length; i++)
            {
                decrypter += Convert.ToString(Convert.ToChar(((Convert.ToInt16(d[i]) - Convert.ToInt16(key[i % key.Length])) % 676)));
            }

            return decrypter;
        }
    }
}
