using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIo_Demo
{
    internal class FileStreamDemo
    {
        public static void FileStreamExample()
        {
            FileStream file = new FileStream(@"F:\c#practice\FileIo_Demo\FileIo_Demo\Demo.txt",FileMode.OpenOrCreate);
            file.WriteByte((byte)65);
            file.Close();
        }
        public static void FileStreamRead()     
        {
            FileStream file = new FileStream(@"F:\c#practice\FileIo_Demo\FileIo_Demo\Demo.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = file.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
        }

        public static void StreamWriterDemo()
        {
            FileStream f = new FileStream(@"E:\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("hello c#");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
        }

        public static void StreamReadDemo()
        {
            FileStream f = new FileStream(@"E:\output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

          string res=  s.ReadLine();
            Console.WriteLine(res);
        }

        public static void BinaryWriterDemo()
        {

            string fileName = @"E:\binaryFile.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine("Data written successfully...");


        }

        public static void BinaryReaderDemo()
        {
            string fileName = @"E:\binaryFile.dat";
            using(BinaryReader reader=new BinaryReader(File.Open(fileName,FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }


        }

    }
}
