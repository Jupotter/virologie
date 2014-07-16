using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Virologie
{
    class FileExplorer
    {
        public void ExploreAndApply()
        {
            IEnumerable<String> files = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.jpg", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
