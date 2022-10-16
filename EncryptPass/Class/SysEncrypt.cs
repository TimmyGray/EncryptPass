
using System.Text;

using System.Security.Cryptography;

namespace EncryptPass.Class
{
    internal class SysEncrypt
    {
       
        readonly byte[] addentropy = { 2, 4, 5, 7, 5, 1 };

        private string Protect(string pass)
        {
            try
            {
                UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
           
                byte[] encryptpass = ProtectedData.Protect(unicodeEncoding.GetBytes(pass), addentropy, DataProtectionScope.LocalMachine);

                return Convert.ToBase64String(encryptpass);
            }

            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;

            }
        }

        internal void Encrypt()
        {
            Console.Write("Введите пароль для шифровки - ");

            string pass = Console.ReadLine();

            string encryptpass = Protect(pass);

            using (StreamWriter sw = File.CreateText("./pass.txt"))
            {
                sw.Write(encryptpass);
            }

            Console.WriteLine("Записано");


        }

    }
}
