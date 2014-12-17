using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPrac_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> aDictionary = new Dictionary<int, string>();

            aDictionary.Add(100,"Java");
            aDictionary.Add(200,"PHP");
            aDictionary.Add(300,"ASP.Net");

            string courseName = (string) aDictionary[300];

            Console.WriteLine(courseName);

            Console.ReadLine();


        }
    }
}
