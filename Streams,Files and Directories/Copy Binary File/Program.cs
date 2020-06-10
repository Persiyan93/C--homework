using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("francemap.gif", FileMode.Open);
            using (fileStream)
            {
                FileStream resultStream = new FileStream("resultStream.gif", FileMode.Create);
                using (resultStream)
                {
                    byte[] buffer =new byte[fileStream.Length];
                    fileStream.Read(buffer, 0, buffer.Length);
                    resultStream.Write(buffer, 0, buffer.Length);
                }



            }
        }
    }
}
