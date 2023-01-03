using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    public static class Garbage
    {
        public static void Collecting()
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[5000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
            Console.WriteLine("--------------");
            long bytes1 = GC.GetTotalMemory(false);
            byte[] memory = new byte[1000 * 1000 * 10];
            memory[0] = 1;
            long bytes2 = GC.GetTotalMemory(false);
            long bytes3 = GC.GetTotalMemory(true);
            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1);
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);
        }
    }
}
