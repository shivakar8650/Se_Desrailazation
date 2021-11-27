using System;
using System.IO;

namespace FileIOoperationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welcome to the file handling program.");

            // FileExist();
            // Console.WriteLine("------------------");
            // ReadAllLines();
            // Console.WriteLine("------------------");
            // ReadAllText();
            //Console.WriteLine("------------------");
            // CopyFile();

            // DeleteFile();

            //StreamReaderReadData();

            // StreamWriteData();

            /* BinarySerialization binarySerialization = new BinarySerialization();
             binarySerialization.Serialisation();
             binarySerialization.Deserialisation();*/

            /* JSONSerialization obj = new JSONSerialization();
             obj.JsonSerialize();

             obj.JsonDesrialize();*/

            XMLSerialization xml_obj = new XMLSerialization();
            xml_obj.SerializeXML();
            xml_obj.DeserializeXML();
        }

        /*   public static void FileExist()
           {
               string FilePath = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example.txt";
               if(File.Exists(FilePath))
               {
                   Console.WriteLine("file is exist");

               }
               else
               {
                   Console.WriteLine("file not exist");
               }
           }


           public static void ReadAllLines()
           {
               string Path = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example.txt";
               string[] lines;
               lines = File.ReadAllLines(Path);
               Console.WriteLine(lines[0]);
               Console.WriteLine(lines[1]);
               Console.ReadKey();
           }

           public static void ReadAllText()
           {
               string Path = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example.txt";
               string lines;
               lines = File.ReadAllText(Path);
               Console.WriteLine(lines);
               Console.ReadKey();
           }

           public static void CopyFile()
           {
               string Path = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example.txt";
               string CopyPath = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Examplenew.txt";

               File.Copy(Path,CopyPath);

               Console.ReadKey();
           }

           public static void DeleteFile()
           {
              // string Path = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example.txt";
               string CopyPath = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Examplenew.txt";

               File.Delete(CopyPath);

               Console.ReadKey();
           }
           public static void StreamReaderReadData()
           {
                string Path = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example.txt";
               using (StreamReader sr = File.OpenText(Path))
               {
                   string s = "";
                   while ((s = sr.ReadLine()) != null)
                   {
                       Console.WriteLine(s);
                   }
               }

               Console.ReadKey();
           }

           public static void StreamWriteData()
           {
               string Path = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example.txt";

               Console.WriteLine(File.ReadAllText(Path));
               using (StreamWriter sr = File.AppendText(Path))
               {

                   Console.WriteLine("hello shivakar you performed good");
                   sr.Close();

                   Console.WriteLine(File.ReadAllText(Path));
               }

               Console.ReadKey();
           }
       }*/
    }
   
}
