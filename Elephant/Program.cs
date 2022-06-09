using System;
using System.IO;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            TransformToElephant();
            Console.WriteLine("Муха");
        }

        static void TransformToElephant()
        {
            Console.WriteLine("Слон");
            TextWriter backupOut = Console.Out; 
            Console.SetOut(TextWriter.Null);
        }
    }
}
