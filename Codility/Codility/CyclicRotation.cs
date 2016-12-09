using System;
using System.Linq;
using System.Text;

namespace Codility
{
    public static class CyclicRotation
    {
        public static T[] CyclicRotationArray<T>(T[] array, int count) where T : IComparable
        {
            if (array.Length == 0)
            {
                return array;
            }

            if (count < 0)
            {
                return array;
            }

            if (count == array.Length)
            {
                return array;
            }
                
            count %= array.Length;

            var result = new T[array.Length];

            Array.Copy(array, array.Length - count, result, 0, count);
            Array.Copy(array, 0, result, count, array.Length - count);

            return result;
        }

        public static string ArrToStr<T>(T[] array) where T : IComparable
        {
            var str = new StringBuilder();

            foreach (var item in array)
            {
                str.Append(item);

                if (item.CompareTo(array.Last()) != 0)
                {                 
                    str.Append(", ");
                }
            }

            return str.ToString();
        }
    }
}
