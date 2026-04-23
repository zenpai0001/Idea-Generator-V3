using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using Terminal.Gui;
using Terminal.Gui.ViewBase;

namespace Idea_Generator_V3
{
    public class FileHandler
    {
        public string? filePath {get; set;}

        //Lazy load the lines from the filePath provided.
        public static async IAsyncEnumerable<string> GetData(string filePath)
        {
            string line;
            using (var reader = new StreamReader(filePath)) 
            {
                while ((line = reader.ReadLine()) != null)
                {
                    await foreach (var item in GetData(filePath))
                    {
                        yield return line;
                    }
 
                }
            }
        }
        public class Randomizer
        {
            private static Random _random = new Random();
            private FileHandler _fileHandler = new FileHandler();
            private IAsyncEnumerator<string> _dataEnumerator;

            public void RandomizeText()
            {
                //Get the data from the file and randomize it.
                _dataEnumerator = GetData(_fileHandler.filePath).GetAsyncEnumerator();

                /*
                 * Work in progress, this is a bit tricky to be honest but I think I can make it work.
                foreach (var item in _dataEnumerator(_fileHandler.filePath))
                {
                    int index = _random.Next(0, item.Length);
                    string randomLine = item[index];
                    Console.WriteLine(randomLine);
                }*/

            }

        }
        
    }
}
