using Core;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4 });
            arrayList.AddLast(5);

            int k = arrayList.RemoveAll(2);
            
            arrayList.Write();
        }
    }
}
