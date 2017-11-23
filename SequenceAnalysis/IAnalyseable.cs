namespace SequenceAnalysis
{
	public interface IAnalyseable
	{
		/// <summary>
		/// Finds the uppercase letters in a string and order it alphabetically.
		/// </summary>
		/// <returns>The uppercase letters alphabetically ordered.</returns>
		/// <param name="inputText">Input text.</param>
		string FindUppercaseLettersOrderAsc(string inputText);
	}
}