using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPrac2_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> aStack=new Stack<int>();

            aStack.Push(100);
            aStack.Push(200);
            aStack.Push(300);

            foreach (var i in aStack)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
