using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text;

namespace FileIOoperationDemo
{
    class BinarySerialization
    {
        public void Serialisation()
        {
            Demo sample = new Demo();
            FileStream filestream = new FileStream(@"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(filestream, sample);
            //Console.ReadKey();
            filestream.Close();


        }



        public void Deserialisation()
        {
            Console.WriteLine("desirialisation");
            string path = @"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\Example1.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream filestream;
            if (File.Exists(path))
            {
                filestream = File.OpenRead(path);
                Demo deserialisedSample = (Demo)formatter.Deserialize(filestream);
                Console.WriteLine($"ApplicationName :{deserialisedSample.ApplicationName} ----------ApplicationId {deserialisedSample.ApplicationId}");
                filestream.Close();
            }
            Console.ReadKey();
        }

    }

    [Serializable]
    public class Demo
    {
        public string ApplicationName { set; get; } = "Binary Serialize";
        public int ApplicationId { set; get; } = 1001;
    }
}
