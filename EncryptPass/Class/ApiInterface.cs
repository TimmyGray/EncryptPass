using System;
using System.Collections.Generic;


namespace EncryptPass.Class
{
    internal class ApiInterface
    {

        public ApiInterface()
        {
            Console.WriteLine("Добро пожаловать в шифровальщик паролей\nВыберите 1, для шифрования с помощью XOR\nВыберите 2, для шифрования через ProtectedData");
        }

        public int Chose { get; private set; }

        

        public void Choose()
        {
            try
            {
                Chose = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

               Console.WriteLine("Введите 1 или 2");
               Choose();    

            }
           

        }

    }
}
