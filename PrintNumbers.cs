using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventAsync
{
    class PrintNumbers
    {
        public EventHandler<int> Progress;
        public void DoWorkBasedOnCount(int count)
        {
            for(int i =0;i<count;i++)
            {
                if(Progress != null)
                {
                    Progress(this, i);
                }
            }

        }
        public async void PrintNumberonCount(int count)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Value:{i.ToString()}");

                }
            }
                );
            Console.WriteLine("Printing Completed");
        }
    }
}
