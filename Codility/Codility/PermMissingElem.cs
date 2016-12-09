using System;

namespace Codility
{
	public static class PermMissingElem
	{
		public static int Solution(int[] a, int n)
		{
			Array.Sort(a);

			var result = 1;

			foreach (var number in a)
			{
				if (number == result)
					result++;
				else
					break;
			}

			return result;
		}
	}
}
