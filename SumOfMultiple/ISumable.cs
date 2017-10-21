namespace SumOfMultiple
{
	public interface ISumable
	{
		/// <summary>
		/// Finds the sum of naturals multiples of 3 or 5 given a certain limit.
		/// </summary>
		/// <returns>The sum of naturals multiples 3 or 5 up to the limit.</returns>
		/// <param name="limit">Limit.</param>
		long FindSumNaturalsMultiple3or5(int limit);
	}
}
