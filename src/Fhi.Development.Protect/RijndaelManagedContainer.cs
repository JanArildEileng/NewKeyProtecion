using System.Security.Cryptography;

namespace Fhi.Felles.KeyProtection
{
    public class RijndaelManagedContainer
    {
        public byte[] Key { get; private set; }
        public byte[] Vector { get; private set; }
        public ICryptoTransform EncryptorTransform;
        public ICryptoTransform DecryptorTransform;

        public RijndaelManagedContainer(byte[] key, byte[] vector)
        {
            var rijndaelManaged = new RijndaelManaged();

            Key = key;
            Vector = vector;
            EncryptorTransform = rijndaelManaged.CreateEncryptor(Key, Vector);
            DecryptorTransform = rijndaelManaged.CreateDecryptor(Key, Vector);
        }
    }
}
