using System;

namespace BKK
{
    public interface ICrypt
    {
        string Encrypt(string input);
    }

    public class BKKCrypt : ICrypt
    {
        public string Encrypt(string input)
        {
            return input;
        }
    }

    public static class SecureBKKCrypt
    {
        /// <summary>
        /// Encrypt extension method
        /// </summary>
        /// <param name="passToEncrypt"></param>
        /// <returns></returns>
        public static string Encrypt(this string passToEncrypt)
        {
            return passToEncrypt;
        }
    }
}
