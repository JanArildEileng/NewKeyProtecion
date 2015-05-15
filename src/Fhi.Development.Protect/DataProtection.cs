using System.Security.Cryptography;

namespace Fhi.Felles.KeyProtection
{
    public class DataProtection
    {
        public static byte[] ProtectForUser(byte[] data)
        {
            // Encrypt the data using DataProtectionScope.CurrentUser. The result can be decrypted 
            //  only by the same current user. 
            return ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
        }
    }
}
