using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace EventAsync

{
    class Program
    {
        static void Main(string[] args)
        {
            MainMethod();  
        }
        public static void MainMethod()
        {
            PrintNumbers pn = new PrintNumbers();
            pn.Progress += new EventHandler<int>((s, e) => { Console.WriteLine($"Sender: {s.ToString()}:value:{e.ToString()}"); });
            Console.WriteLine("Event Handling");
            pn.DoWorkBasedOnCount(10);
            Console.WriteLine("Async Await");
            pn.PrintNumberonCount(10);
            Console.WriteLine("Main Method: End");
            Console.ReadLine();
        }
    }
}
