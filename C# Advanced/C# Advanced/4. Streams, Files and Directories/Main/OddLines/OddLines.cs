﻿namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
         
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line=string.Empty;
                    int counter = 0;
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        if (counter%2==1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
