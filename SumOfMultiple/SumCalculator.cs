using System;

namespace SumOfMultiple
{
	public class SumCalculator : ISumable
	{
		public long FindSumNaturalsMultiple3or5(int limit)
		{
			long sum = 0;

			for (int i = 0; i < limit; i++) {
				bool isMultipleOf3or5 = (i % 3 == 0) || (i % 5 == 0);

				if (isMultipleOf3or5) {
					sum += i;
				}
			}

			return sum;
		}
	}
}
