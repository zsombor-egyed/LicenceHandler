using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace LicenceHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string fileToEncrypt = @"C: \Users\Zsombor\Documents\Visual Studio 2015\Projects\LicenceHandler\docs\LICENSE";
                string fileToDecrypt = @"C:\Users\Zsombor\Documents\Visual Studio 2015\Projects\LicenceHandler\Encrypt\LICENSE.enc";
                string key = "palmon";


                RSAProvider rsap = new RSAProvider(key);
               rsap.encryptUsingPublicKey(fileToEncrypt);
               rsap.decryptFileUsingPrivateKey(fileToDecrypt, "palmon");             
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
