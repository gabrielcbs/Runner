using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NSubstitute;

namespace SequenceAnalysis.Tests
{
	[TestClass]
	public class AnalyserTests
	{
		[TestMethod]
		public void Test_FindUppercaseLettersOrderAsc()
		{
			// Arrange
			IInputTextLogger inputTextLogger = Substitute.For<IInputTextLogger>();
			IAnalyseable analyser = new Analyser(inputTextLogger);
			string inputValue = "This IS a STRING";
			string expectedValue = "GIINRSSTT";


			// Act
			var actualValue = analyser.FindUppercaseLettersOrderAsc(inputValue);

			// Assert
			Assert.AreEqual(expectedValue, actualValue);
		}

		[TestMethod]
		/// <summary>
		/// Mock Framework: NSubstitute
		/// 
		/// Test to verify that the mocked dependency IInputTextLogger 
		/// has its method LogWordCountForText() being called.
		/// </summary>
		public void Test_FindUpperCaseLettersOrderAsc_Calls_LogWordCount_NSubstitute()
		{
			// Arrange
			IInputTextLogger inputTextLoggerMock = Substitute.For<IInputTextLogger>();
			IAnalyseable analyser = new Analyser(inputTextLoggerMock);
			string inputValue = "This IS a STRING";

			// Act
			analyser.FindUppercaseLettersOrderAsc(inputValue);

			// Assert
			inputTextLoggerMock.Received().LogWordCountForText(inputValue, Arg.Any<int>());
		}

		[TestMethod]
		/// <summary>
		/// Mock Framework: Moq
		/// 
		/// Test to verify that the mocked dependency IInputTextLogger 
		/// has its method LogWordCountForText() being called.
		/// </summary>
		public void Test_FindUpperCaseLettersOrderAsc_Calls_LogWordCount_Moq()
		{
			// Arrange
			var inputTextLoggerMock = new Mock<IInputTextLogger>();
			IAnalyseable analyser = new Analyser(inputTextLoggerMock.Object);
			string inputValue = "This IS a STRING";

			// Act
			analyser.FindUppercaseLettersOrderAsc(inputValue);

			// Assert
			inputTextLoggerMock.Verify(x => x.LogWordCountForText(It.IsAny<string>(), It.IsAny<int>()));
		}

		[TestMethod]
		/// <summary>
		/// Mock Framework: FakeItEasy
		/// 
		/// Test to verify that the mocked dependency IInputTextLogger 
		/// has its method LogWordCountForText() being called.
		/// </summary>
		public void Test_FindUpperCaseLettersOrderAsc_Calls_LogWordCount_FakeItEasy()
		{
			// Arrange
			var inputTextLoggerMock = A.Fake<IInputTextLogger>();
			IAnalyseable analyser = new Analyser(inputTextLoggerMock);
			string inputValue = "This IS a STRING";

			// Act
			analyser.FindUppercaseLettersOrderAsc(inputValue);

			// Assert
			A.CallTo(() => inputTextLoggerMock.LogWordCountForText(A<string>._, A<int>._)).MustHaveHappened();
		}
	}
}