using System;
using System.Collections.Generic;
using System.Text;

namespace wylistuj
{
    public class FileMetaInfo
    {
        public string FilePath { get; set; }
        public List<string> FileNames = new List<string>();
        public List<int> FileBytes = new List<int>();
        public List<int> FileKiloBytes = new List<int>();
        public List<int> FileMegaBytes = new List<int>();
        public List<int> FileGigaBytes = new List<int>();

    }
}
