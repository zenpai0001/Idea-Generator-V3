using System;
using System.Collections.Generic;
using System.Text;

using Terminal.Gui;

namespace Idea_Generator_V3
{
    public class FileHandler
    {
       
            
        public FileHandler() 
        {
        }

        public static IEnumerable<string> GetData(string filePath)
        {
            using (var reader = new StreamReader(filePath)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
