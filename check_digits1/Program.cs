using System;

namespace IntroCS {
	class CheckDigits {
		static void Main() {
			string s = UIF.PromptLine("Enter a line: ");
			Console.WriteLine(IsDigits(s));
		}
		static bool IsDigits(string s) {
			bool allDigitsSoFar = (s.Length > 0);
			int i = 0;
			while (i < s.Length) {
				if (s[i] < '0' || s[i] > '9') {
					allDigitsSoFar = false;
				}
				i++;
			}
			return allDigitsSoFar;
		}
	}
}