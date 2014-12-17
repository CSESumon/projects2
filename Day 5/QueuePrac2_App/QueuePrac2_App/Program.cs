using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePrac2_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue= new Queue<int>();
            aQueue.Enqueue(100);
            aQueue.Enqueue(200);
            aQueue.Enqueue(300);
            aQueue.Enqueue(400);

            foreach (var anItem in aQueue)
            {
                Console.WriteLine(anItem);
                
            }

            Console.ReadLine();
        }
    }
}
