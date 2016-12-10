using System;

namespace IntroCS {
	class SumToNTest {
		static long SumToN(int n) {
			return (long)n * (n + 1) / 2;
		}

		static void Main() {
			int n = UIF.PromptInt("Enter the largest number in the sum: ");
			Console.WriteLine("The sum of 1 through {0} is {1}", n, SumToN(n));
		}
	}
}