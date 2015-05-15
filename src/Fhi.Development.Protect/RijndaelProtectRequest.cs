
namespace Fhi.Felles.KeyProtection
{
    public class RijndaelProtectRequest
    {
        public string ProtectedKeyPath { get; private set; }
        public string ProtectedIVPath { get; private set; }

        public RijndaelManagedContainer RijndaelManagedContainer { get; private set; }

        public RijndaelProtectRequest(RijndaelManagedContainer rijndaelManagedContainer, string protectedKeyPath, string protectedIVPath)
        {
            RijndaelManagedContainer = rijndaelManagedContainer;
            ProtectedKeyPath = protectedKeyPath;
            ProtectedIVPath = protectedIVPath;
        }
    }
}
