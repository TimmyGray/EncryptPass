using EncryptClass;
using EncryptPass.Class;


ApiInterface api = new ApiInterface();

api.Choose();

if (api.Chose ==1)
{

    OwnEncrypt encrypt = new OwnEncrypt();

    encrypt.SetKey();

    encrypt.EncryptPass();

    TestDecrypt decrypt = new TestDecrypt();

    decrypt.DecryptPass();

}
else if(api.Chose ==2)
{
    SysEncrypt encrypt = new SysEncrypt();

    encrypt.Encrypt();

    Console.WriteLine("Проверка расшифровкой");

    string encryptpass;

    using (StreamReader sr = File.OpenText("./pass.txt"))
    {
        encryptpass = sr.ReadToEnd();
    }


    string decryptpass = SysDecrypt.Decrypt(encryptpass);

    Console.WriteLine($"Ваш пароль - {decryptpass}");

    Console.ReadKey();
}

else
{
    return;
}



