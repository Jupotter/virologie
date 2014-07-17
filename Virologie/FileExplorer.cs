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

        public void ApplyTo(string startDir, IEnumerable<string> filters, FileAction action)
        {
            var enumerable = filters as IList<string> ?? filters.ToList();
            foreach (var filter in enumerable)
            {
                foreach (var file in EnumerateFiles(startDir, filter))
                {
                    action(file);
                }
            }
            foreach (var directory in Directory.GetDirectories(startDir))
            {
                ApplyTo(directory, enumerable, action);
            }
        }

        public IEnumerable<string> EnumerateFiles(string startDir, string filter)
        {
            return Directory.GetFiles(startDir, filter, SearchOption.TopDirectoryOnly);
        }

        static public void ReplaceFile(string name)
        {
            if (!File.Exists(name + ".crypt")) return;
            File.Delete(name);
            File.Move(name + ".crypt", name);
        }
    }
}
