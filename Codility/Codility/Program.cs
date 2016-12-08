using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryGap.GetBinaryGap(12312));
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            a = CyclicRotation.CyclicRotationArray(a, 7);
            Console.WriteLine(CyclicRotation.ArrToStr(a));
        }
    }
}
