using System;

namespace IntroCS {
	class ReversedLoop {
		static void Main() {
			var s = UIF.PromptLine("Enter a line: ");
			PrintReversed(s);
			PrintReversed2(s);
		}

		// Method that was created by me
		static void PrintReversed(string s) {
			int i = 0;
			while (i < s.Length) {
				Console.Write(s[s.Length - (i + 1)]);
				i++;   
			}
		}

		// Method that the college is using
		static void PrintReversed2(string s) {
			int i = s.Length - 1;
			while (i >= 0) {
				Console.Write(s[i]);
				i--;
			}
		}
	}
}