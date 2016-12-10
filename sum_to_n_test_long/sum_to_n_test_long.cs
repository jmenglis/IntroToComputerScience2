using System;

namespace IntroCS {
	class SumToNTest {
		static long SumToN(int n) {
			long sum = 1, i = 2;
			while (i <= n) {
				sum = sum + i;
				i = i + 1;
			}
			return sum;
		}

		static void Main() {
			int n = UIF.PromptInt("Enter the largest number in the sum: ");
			Console.WriteLine("The Sum of 1 through {0} is {1}.", n, SumToN(n));
		}
	}
}
