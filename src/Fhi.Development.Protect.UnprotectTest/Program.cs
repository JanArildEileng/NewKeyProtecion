using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Fhi.Felles.KeyProtection.UnprotectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Specify path to protected string (file)");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Unprotected string: " + UnProtectStringForUser(args[0]));
            Console.WriteLine();
        }

        public static string UnProtectStringForUser(string path)
        {
            var bytes = File.ReadAllBytes(path);
            return Encoding.UTF8.GetString(UnProtectForUser(bytes));
        }

        public static byte[] UnProtectForUser(byte[] data)
        {
            // Encrypt the data using DataProtectionScope.CurrentUser. The result can be decrypted 
            //  only by the same current user. 
            return ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
        }
    }
}
