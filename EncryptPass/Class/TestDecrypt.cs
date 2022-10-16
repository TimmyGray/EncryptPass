
using System.Text;


namespace EncryptPass.Class
{
    internal class TestDecrypt
    {

        private uint _key;

        private string DecryptChar(string pass)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char word in pass)
            {
                char secretchar = (char)(word ^ _key);
                sb.Append(secretchar);
            }
            return sb.ToString();
        }

        internal void DecryptPass()
        {

            string encryptpass;
            
            using (StreamReader sr = File.OpenText("./pass.txt"))
            {
                encryptpass = sr.ReadToEnd();
            }
            Console.Write("Введите секретный ключ для дешифровки - ");
            
            try
            {
                _key = Convert.ToUInt32(Console.ReadLine());
                DecryptChar(encryptpass);
            }
            catch (Exception)
            {

                Console.WriteLine("Вы ввели неверный ключ!");
                DecryptPass();
            }
           

            string decryptpass = DecryptChar(encryptpass);


            Console.WriteLine($"Ваш пароль - {decryptpass}");

        }

        public TestDecrypt()
        {
            Console.WriteLine("Проверочная расшифровка пароля");

        }


    }
}
