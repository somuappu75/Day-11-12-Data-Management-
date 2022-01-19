using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonFile
{
   public  class FetchJsonForRice
    {
        public Rice ReadTheJsonFile(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}
