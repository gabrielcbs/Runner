using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SequenceAnalysis
{
	public class Analyser : IAnalyseable
	{
		private IInputTextLogger inputTextLogger;

		public Analyser(IInputTextLogger inputTextLogger)
		{
			this.inputTextLogger = inputTextLogger;
		}

		public string FindUppercaseLettersOrderAsc(string inputText)
		{
			string pattern = @"[A-Z]";

			MatchCollection parsedWord = Regex.Matches(inputText, pattern);

			var regexList = parsedWord.Cast<Match>().Select(match => match.Value).ToList();

			inputTextLogger.LogWordCountForText(inputText, regexList.Count());

			string stringList = String.Join(String.Empty, regexList);

			return String.Concat(stringList.OrderBy(c => c));
		}
	}
}
