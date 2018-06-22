using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Negocio
{
    public class Validacion
    {
        public bool validarContra(String contra, String contra2)
        {

            if (contra == contra2)
            {
                return true;
            }
            return false;
        }
        public string GetMd5Hash(MD5 md5Hash, string contrasena)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(contrasena));

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
