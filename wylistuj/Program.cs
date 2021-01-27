using System;
using System.Collections.Generic;
using System.IO;

namespace wylistuj
{
    class Program
    {
        static void Main(string[] args)
        {
            FileMetaWritter fileMetaWritter = new FileMetaWritter();
            FileMetaInfo fileMetaInfo = new FileMetaInfo();

            Console.Write("copy the file path to check its contents: ");
            fileMetaWritter.GetFilePath(fileMetaInfo);

            DirectoryInfo di = new DirectoryInfo(fileMetaInfo.FilePath);  

            if (!File.Exists(fileMetaInfo.FilePath))
            {
                try
                {
                    Directory.SetCurrentDirectory(fileMetaInfo.FilePath);
                }
                catch (DirectoryNotFoundException FilePathEx)
                {
                    Console.WriteLine("Directory not found: " + FilePathEx.Message);
                }
            }
            else
            {
                Console.WriteLine(fileMetaInfo.FilePath);
            }
        }
    }
}
