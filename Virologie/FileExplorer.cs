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

        public void ExploreAndApply(string filter, FileAction action)
        {
            IEnumerable<String> files = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), filter, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                action(file);
            }
        }
    }
}
