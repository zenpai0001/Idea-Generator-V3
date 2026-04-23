using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Idea_Generator_V3
{
    
    public class Serializer
    {
        //Basic serializer class to convert the generated idea into a JSON format.

        [JsonProperty("id")]
        public int generatedID;

        [JsonProperty("text")]
        public Dictionary<string, string> text;

        public Serializer(int id, Dictionary<string, string> text)
        {
            this.generatedID = id;
            this.text = text;
        }
        public void SerializeToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            filePath = @"C:\Users\zenpa\source\repos\Idea Generator V3\Data.json";
            System.IO.File.WriteAllText(filePath, json);
        }
        public void DeserializeFromJson(string filePath)
        {
            Serializer deserializedObject = new Serializer(0, null);
            string json = System.IO.File.ReadAllText(filePath);
            filePath = @"C:\Users\zenpa\source\repos\Idea Generator V3\Data.json";
            deserializedObject = JsonConvert.DeserializeObject<Serializer>(json);
            generatedID = deserializedObject.generatedID;
            text = deserializedObject.text;
        }

    }
}
