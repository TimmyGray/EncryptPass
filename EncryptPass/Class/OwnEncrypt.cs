
using System.Text;

namespace EncryptPass.Class
{
    internal class OwnEncrypt
    {

        private uint _key;

        internal uint SetKey()
        {
            Console.Write("Введите секретный ключ к паролю. Это должно быть число - ");
            try
            {
                return _key = Convert.ToUInt32(Console.ReadLine());
                
            }
            catch (Exception)
            {

               Console.WriteLine("Введите корректное значение!");
               return SetKey();
            }

            
        }

        private string EncryptChar(string pass)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char word in pass)
            {
                char secretchar = (char)(word ^ _key);
                sb.Append(secretchar);
            }
            return sb.ToString();
        }

       internal void EncryptPass()
       {
            Console.Write("Введите пароль для шифровки - ");
            
            string encryptpass = EncryptChar(Console.ReadLine());

            using (StreamWriter sw = File.CreateText("./pass.txt"))
            {
                sw.Write(encryptpass);
            }

            Console.WriteLine("Записано");

       }

       

    }
}
