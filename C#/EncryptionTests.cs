using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BKK
{
    [TestClass]
    public class EncryptionTests
    {
        /// <summary>
        /// Encryptor test
        /// </summary>
        [TestMethod]
        public void EncyrptionTest()
        {
            const string password = "mySuperSecurePassword";
            BKKCrypt bkkCrypt = new BKKCrypt();
            Assert.AreEqual(bkkCrypt.Encrypt(password), password);
        }

        /// <summary>
        /// Encrypt extension method test
        /// </summary>
        [TestMethod]
        public void EncryptExtensionMethodTest()
        {
            const string password = "mySuperSecurePassword";
            Assert.AreEqual(password.Encrypt(), password);
        }
    }
}
