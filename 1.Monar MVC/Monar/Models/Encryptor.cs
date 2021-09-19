using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Monar.Models
{
    public class Encryptor
    {
        public string Encriptar(string contraseña, string llave)
        {
            byte[] keyArray;
            byte[] encryptar = Encoding.UTF8.GetBytes(contraseña);

            keyArray = Encoding.UTF8.GetBytes(llave);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = tdes.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(encryptar, 0, encryptar.Length);
            tdes.Clear();

            return Convert.ToBase64String(resultado, 0, resultado.Length);

        }

        public string Decriptar(string contraseña, string llave)
        {
            byte[] keyArray;
            byte[] decryptar = Convert.FromBase64String(contraseña);

            keyArray = Encoding.UTF8.GetBytes(llave);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = tdes.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(decryptar, 0, decryptar.Length);
            tdes.Clear();

            return Encoding.UTF8.GetString(resultado);
        }
    }
}