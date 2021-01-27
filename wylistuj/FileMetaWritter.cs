using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace wylistuj
{
    public class FileMetaWritter
    {
        public void GetFilePath(FileMetaInfo fileMetaInfo)
        {
            fileMetaInfo.FilePath = Console.ReadLine();
        }

        public void GetFileNames(FileMetaInfo file)
        {
            foreach (var item in file.FileNames)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowFileBytes(FileMetaInfo file)
        {
            foreach (var item in file.FileBytes)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowFileKiloBytes(FileMetaInfo file)
        {
            foreach (var item in file.FileKiloBytes)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowFileMegaBytes(FileMetaInfo file)
        {
            foreach (var item in file.FileMegaBytes)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowFileGigaBytes(FileMetaInfo file)
        {
            foreach (var item in file.FileGigaBytes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
