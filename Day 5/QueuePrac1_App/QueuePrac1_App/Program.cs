using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePrac1_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> aQueue = new Queue<string>();
            aQueue.Enqueue("Sumon");
            aQueue.Enqueue("Masu");
            aQueue.Enqueue("Shubu");
            aQueue.Enqueue("Mehi");
            aQueue.Enqueue("jitu");
            Console.WriteLine(aQueue.Dequeue());
            Console.WriteLine(aQueue.Dequeue());

            Console.ReadLine();
        }
    }
}
