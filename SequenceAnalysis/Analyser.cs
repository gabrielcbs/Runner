using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SequenceAnalysis
{
	public class Analyser : IAnalyseable
	{
		public string FindUppercaseLettersOrderAsc(string inputWord)
		{
			string pattern = @"[A-Z]";

			MatchCollection parsedWord = Regex.Matches(inputWord, pattern);

			var regexList = parsedWord.Cast<Match>().Select(match => match.Value).ToList();

			string stringList = String.Join(String.Empty, regexList);

			return String.Concat(stringList.OrderBy(c => c));
		}
	}
}
