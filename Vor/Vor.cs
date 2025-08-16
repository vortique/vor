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

                if (File.Exists(args[0]))
                {
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
                        Console.WriteLine("File doesn't exists! Please ensure file's location.");
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Console.WriteLine("File's directory doesn't exists! Please ensure file's location.");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("Something went wrong.\n" + e);
                    }
                }
                else
                {
                    Console.WriteLine("File doesn't exists! Please ensure file's location.");
                }
            }
        }
    }
}