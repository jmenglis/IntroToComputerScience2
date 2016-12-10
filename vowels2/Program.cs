using System;

namespace IntroCS {
	class Vowels2 {
		static void Main() {
			string s = UIF.PromptLine("Enter a line: ");
			PrintVowels(s);
		}
		static void PrintVowels(string s) {
			int i = 0;
			string vowels = "aeiouAEIOU";
			while (i < s.Length) {
				if (vowels.Contains(""+s[i])) {
					Console.WriteLine(s[i]);
				}
				i++;
			}
		}
	}
}