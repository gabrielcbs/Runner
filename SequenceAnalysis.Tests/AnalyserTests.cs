using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SequenceAnalysis.Tests
{
	[TestClass]
	public class AnalyserTests
	{
		[TestMethod]
		public void Test_FindUppercaseLettersOrderAsc()
		{
			// Arrange
			IAnalyseable analyser = new Analyser();
			string inputValue = "This IS a STRING";
			string expectedValue = "GIINRSSTT";


			// Act
			var actualValue = analyser.FindUppercaseLettersOrderAsc(inputValue);

			// Assert
			Assert.AreEqual(expectedValue, actualValue);
		}
	}
}
