using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablePrac_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHash= new Hashtable();

            aHash.Add("100", "Asp.Net");
            aHash.Add("101", "Java");
            aHash.Add("102", "PHP");
            aHash.Add("103", "SEO");

            string courseName=(string) aHash["101"];
            Console.WriteLine(courseName);

            Console.ReadLine();
        }
    }
}
