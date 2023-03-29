using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Console;
using System.IO;
namespace cs
{
    public class Value
    {
        public Value()
        {

        }
        public int value_1 { get; set; }
        public int value_2 { get; set; }
        public int value_3 { get; set; }
    }
    internal class Multithreading
    {
        static void Main(string[] args)
        {
            Random rand_val = new Random();
            Value value = new Value();
            value.value_1 = rand_val.Next(0, 11);
            value.value_2 = rand_val.Next(0, 11);
            value.value_3 = rand_val.Next(0, 11);
            int[] values = { value.value_1, value.value_2, value.value_3 };
            string jsonString = JsonSerializer.Serialize(values);
            WriteLine("путь к файлу");
            string file_path = ReadLine();
            using (FileStream stream = new FileStream(file_path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (BinaryWriter writer = new BinaryWriter(stream, Encoding.Unicode))
                {
                    writer.Write(jsonString);
                }
            }
            WriteLine(jsonString);
        }
    }
}