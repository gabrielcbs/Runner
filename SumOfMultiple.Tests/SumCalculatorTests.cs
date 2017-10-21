using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfMultiple.Tests
{
	[TestClass]
	public class SumCalculatorTests
	{
		[TestMethod]
		public void Test_FindUppercaseLettersOrderAsc()
		{
			// Arrange
			ISumable sumCalculator = new SumCalculator();
			int expectedValue = 14;

			// Act
			var actualValue = sumCalculator.FindSumNaturalsMultiple3or5(7);

			// Assert
			Assert.AreEqual(expectedValue, actualValue);
		}
	}
}
