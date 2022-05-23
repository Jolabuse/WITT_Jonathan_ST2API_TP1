using System;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IntroCex5
{
    
    
    
    class Program
    {
        static void ParseJson()
        {
            try
            {
                using (StreamReader r = new StreamReader("DOGE_AllDataPoints_3Days.json"))
                {
                    string line = r.ReadToEnd();
                    Doge d = JsonConvert.DeserializeObject<Doge>(line);
                    d.config.Display();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            
        }
        
        static void Main(string[] args)
        {
            ParseJson();
        }
    }
}