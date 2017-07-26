using System;

namespace BKK
{
    #region Strategy
    /// <summary>
    /// Crypt Strategy base
    /// </summary>
    public abstract class CryptStrategyBase
    {
        public abstract string Crypt(string passToEncrypt);
    }

    /// <summary>
    /// Strategy Context
    /// </summary>
    public class StrategyContext
    {
        private readonly CryptStrategyBase _strategy;

        //for lazy lads
        public StrategyContext()
        {
            this._strategy = new BKKCryptStrategy();
        }
        public StrategyContext(CryptStrategyBase strategy)
        {
            this._strategy = strategy;
        }

        public string Crypt(string passToEncrypt)
        {
            return _strategy.Crypt(passToEncrypt);
        }

    }

    /// <summary>
    /// BKK crypt strategy
    /// </summary>
    public class BKKCryptStrategy : CryptStrategyBase
    {
        public override string Crypt(string passToEncrypt)
        {
            return passToEncrypt.Encrypt();
        }
    }
    #endregion

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
