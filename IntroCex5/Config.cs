using System;
using System.ComponentModel.DataAnnotations;

namespace IntroCex5
{
    public class Config
    {
        public string data { get; set; }
        public int data_points { get; set; }
        public string interval { get; set; }
        public string symbol { get; set; }
        
        public void Display()
        {
            Console.WriteLine("data : {0}",data);
            Console.WriteLine("data_points : {0}",data_points);
            Console.WriteLine("interval : {0}",interval);
            Console.WriteLine("symbol : {0}",symbol);
        }
    }
}