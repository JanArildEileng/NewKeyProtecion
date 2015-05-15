namespace Fhi.Felles.KeyProtection
{
    public class StringProtectRequest
    {
        public string UnprotectedString { get; private set; }
        public string ProtectedStringPath { get; private set; }

        public StringProtectRequest(string unprotectedString, string protectedStringPath)
        {
            UnprotectedString = unprotectedString;
            ProtectedStringPath = protectedStringPath;
        }
    }
}