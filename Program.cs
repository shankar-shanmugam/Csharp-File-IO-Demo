using System;
using System.IO;

namespace FileIo_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  ReadLinesFromFile();
            //  CopyFile();
            //  DeleteFile();

            // DirectoryAccessDemo();

            //  FileStreamDemo.FileStreamExample();
            // FileStreamDemo.FileStreamRead();

            //  FileStreamDemo.StreamWriterDemo();
            //  FileStreamDemo.StreamReadDemo();

          //  FileStreamDemo.BinaryWriterDemo();

            FileStreamDemo.BinaryReaderDemo();
        }

        public static void ReadLinesFromFile()
        {
            string path = @"F:\c#practice\FileIo_Demo\FileIo_Demo\Demo.txt";
            //string[] lines= File.ReadAllLines(path);
            // foreach (string line in lines)
            // {
            //     Console.WriteLine(line);
            // }
            //    or
            Console.WriteLine(File.ReadAllText(path));

        }

        public static void DeleteFile()
        {
            string copyPath = @"F:\c#practice\FileIo_Demo\FileIo_Demo\CopyFileFromexisting.txt";

            File.Delete(copyPath);

            Console.WriteLine("File deleted successfully");
        }

        public static void CopyFile()
        {
            string path = @"F:\c#practice\FileIo_Demo\FileIo_Demo\Demo.txt";

            string copyPath = @"F:\c#practice\FileIo_Demo\FileIo_Demo\CopyFileFromexisting.txt";


            File.Copy(path, copyPath);


        }

        public static void CheckFileExist()
        {

            string path = @"F:\c#practice\FileIo_Demo\FileIo_Demo\Demo.txt";

            if (File.Exists(path))
                Console.WriteLine("file exist already");
            else
            {
                File.Create(path);
                Console.WriteLine(" File not existed so,file created successfully");
            }


        }

        public static void DirectoryAccessDemo()
        {
            // to know the current directory
            //DirectoryInfo info = new DirectoryInfo(".");
            //Console.WriteLine(info.FullName);
            //Console.WriteLine(info.Parent);
            //Console.WriteLine(info.CreationTime);
            //Console.WriteLine(info.Attributes);
            // Specify the directory path

            string directoryPath = @"F:\c#practice\FileIo_Demo\FileIo_Demo\directoryDemo";

            // Check if the directory exists, create it if it doesn't
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine("Directory created at: " + directoryPath);
            }
            else
            {
                Console.WriteLine("Directory already exists at: " + directoryPath);
            }

            // Create and write to a file in the directory
            string filePath = Path.Combine(directoryPath, "demo.txt");

            string[] lines =
            {
            "hello world!",
            "this is super amazing",
            "great to see you"
        };

            // Write all lines to the file
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("File created at: " + filePath);

            // Read the content of the file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File content:");
            Console.WriteLine(content);
        }

    }
}

