namespace Fhi.Felles.KeyProtection
{
    public class ProtectResponse
    {
        public string Log { get; private set; }

        public ProtectResponse(string log)
        {
            Log = log;
        }
    }
}
