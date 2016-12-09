using System;

namespace Codility
{
	public static class FrogJmp
	{
		public static int Solution(int x, int y, int d)
		{
			var count = (y - x) / (double)d;

			return (int)Math.Ceiling(count);
		}
	}
}
