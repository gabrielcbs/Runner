using System;
namespace Runner
{
	public static class ProgramFunctions
	{
		/// <summary>
		/// Executable called “Runner”. It will ask the user which of the problems below to solve.
		/// 
		/// A library called “SumOfMultiple” containing a solution for the following problem:
		/// Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit 
		/// provided as input.
		/// 
		/// A library called “SequenceAnalysis” containing a solution for the following problem:
		/// Find the uppercase words in a string, provided as input, and order all characters in 
		/// these words alphabetically.
		/// 
		/// Input: "This IS a STRING"
		/// Output: "GIINRSST"
		/// 
		/// </summary>
		public static void DoTheMagic()
		{
			String input = String.Empty;
			bool isContinue = false;

			do {
				do {
					Console.WriteLine("Which problem would you like to solve?");
					Console.WriteLine("[1] SumOfMultiple - Sum of all naturals that are multiple of 3 or 5 for a given input.");
					Console.WriteLine("[2] SequenceAnalysis - Find the uppercase words in a string and ordem them alphabetically.");
					input = Console.ReadLine();
					if (!IsValidInput(input)) {
						Console.WriteLine("Invalid parameter. You should type 1 or 2.");
						Console.WriteLine();
					}
				} while (!IsValidInput(input));


				if (input == "1") {
					DoFindSumNaturalsMultipleOf3or5();
				}

				if (input == "2") {
					DoStringAnalysisOrderedUppercases();
				}

				isContinue = CheckContinue();

			} while (isContinue);

		}

		private static bool CheckContinue()
		{
			bool isContinue = false;
			String input2;
			do {
				Console.WriteLine("Would you like to solve another problem?[Y]/[N]");
				input2 = Console.ReadLine();
				if (!IsValidYOrN(input2)) {
					Console.WriteLine("Invalid parameter. You should type Y or N.");
					Console.WriteLine();
				} else {
					isContinue = (input2.ToUpperInvariant().Equals("Y"));
				}

			} while (!IsValidYOrN(input2));
			return isContinue;
		}

		private static bool IsValidYOrN(String input)
		{
			return input.ToUpperInvariant().Equals("Y") || input.ToUpperInvariant().Equals("N");
		}

		private static bool IsValidInput(string input)
		{
			return input == "1" || input == "2";
		}

		private static void DoFindSumNaturalsMultipleOf3or5()
		{
			string input;
			int limit;
			bool validNatual = false;
			do {
				Console.WriteLine("What's the limit?");
				input = Console.ReadLine();
				validNatual = (Int32.TryParse(input, out limit) && limit > 0);

				if (!validNatual) {
					Console.WriteLine("Invalid parameter. You should type a valid natural number.");
				} else {
					long result = new SumOfMultiple.SumCalculator().FindSumNaturalsMultiple3or5(limit);
					Console.WriteLine("The result is :" + result);
					Console.WriteLine();

				}
			} while (!validNatual);
		}



		private static void DoStringAnalysisOrderedUppercases()
		{
			string input;
			Console.WriteLine("What's the string?");
			input = Console.ReadLine();

			string result = new SequenceAnalysis.Analyser().FindUppercaseLettersOrderAsc(input);
			Console.WriteLine("The result is :" + result);
			Console.WriteLine();
		}
	}
}
