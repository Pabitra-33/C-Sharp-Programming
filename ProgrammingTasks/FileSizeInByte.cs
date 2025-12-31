using System;
using System.IO;

namespace ProgrammingTasks
{
    public class FileSizeInByte
    {
        public static long GetFileSizeInBytes(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", filePath);
            }

            // Get the file info and return its size in bytes
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        public static void Main(string[] args)
        {
            string filePath = "testfolder/example.txt"; 

            try
            {
                long fileSize = GetFileSizeInBytes(filePath);
                Console.WriteLine($"The size of the file '{filePath}' is {fileSize} bytes.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}