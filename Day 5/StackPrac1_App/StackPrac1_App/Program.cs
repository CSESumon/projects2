using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPrac1_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> aStack=new Stack<string>();

            aStack.Push("Sumon");
            aStack.Push("Masu");
            aStack.Push("Mehedi");
            aStack.Push("Shubu");

            Console.WriteLine(aStack.Pop());
            Console.WriteLine(aStack.Pop());
           
            Console.ReadLine();
        }
    }
}
