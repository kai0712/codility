using System;
using System.Linq;

namespace Codility
{
    public static class BinaryGap
    {
        public static int GetBinaryGap(int value)
        {
            var binary = Convert.ToString(value, 2);
            
            // Remove 0 at front and end.
            binary = binary.Trim('0');

            // Split as array by 1.
            var arr = binary.Split('1');

            return arr.Max(x => x.Length);                       
        }

    }
}
