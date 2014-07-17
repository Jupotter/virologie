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
            return Directory.EnumerateFiles(startDir, filter, SearchOption.AllDirectories);
        }
    }
}
