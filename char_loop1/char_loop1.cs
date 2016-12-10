using System;

namespace IntroCS {
	class CharLoop {
		static void Main() {
			string s = UIF.PromptLine("Enter a line: ");
			OneCharPerLine(s);
		}
		static void OneCharPerLine(string s) {
			int i = 0;
			while (i < s.Length) {
				Console.WriteLine(s[i]);
				i++;
			}
		}
	}
}