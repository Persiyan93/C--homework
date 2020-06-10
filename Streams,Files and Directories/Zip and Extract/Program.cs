using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {

            string starPath = @"copyMe.png";
            
            string extractPath = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            ZipArchive zipArchive = ZipFile.Open("archiv.zip", ZipArchiveMode.Update);
            using (zipArchive)
            {
                zipArchive.CreateEntryFromFile(starPath, "copy.png");
            }

            ZipFile.ExtractToDirectory("archiv.zip", extractPath);
        }
    }
}
