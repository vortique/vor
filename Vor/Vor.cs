using System;
using System.IO;

namespace Vor
{
    internal class Vor
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                String filePath = args[0];

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        String line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"Vor ({filePath}): No such file or directory");
                }
            }
            else
            {
                Console.WriteLine($"Vor: No such file or directory");
            }
        }
    }
}