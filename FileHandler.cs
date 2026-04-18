using System;
using System.Collections.Generic;
using System.Text;

using Terminal.Gui;

namespace Idea_Generator_V3
{
    public class FileHandler
    {
        public string? filePath {get; set;}

      
        //Lazy load the lines from the filePath provided.
        public static IEnumerable<string> GetData(string filePath)
        {
            string line;
            using (var reader = new StreamReader(filePath)) 
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
        
    }
}
