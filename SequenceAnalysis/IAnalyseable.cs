namespace SequenceAnalysis
{
	public interface IAnalyseable
	{
		/// <summary>
		/// Finds the uppercase letters in a string and order it alphabetically.
		/// </summary>
		/// <returns>The uppercase letters alphabetically ordered.</returns>
		/// <param name="inputWord">Input word.</param>
		string FindUppercaseLettersOrderAsc(string inputWord);
	}
}