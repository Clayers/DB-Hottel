using System;
using System.Security.Cryptography;
using System.Text;

namespace HotelDB
{
    public static class SecurityPasswordController //Класс, отвечаюший за хеширование пароля
    {
        public static string GetMd5Hash(string input) //Получение хеша
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        public static bool VerifyMd5Hash(string input, string hash)  //Сравнение валидности хешей
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hashOfInput = GetMd5Hash(input);
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                if (0 == comparer.Compare(hashOfInput, hash))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}