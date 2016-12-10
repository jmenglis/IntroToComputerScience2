using System;

namespace IntroCS {
	class Vowels {
		static void Main() {
			string s = UIF.PromptLine("Enter a line: ");
			PrintVowels(s);
			PrintVowels2(s);
		}
		static void PrintVowels(string s) {
			int i = 0;
			while (i < s.Length) {
				if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u') {
					Console.WriteLine(s[i]);
				}
				i++;
			}
		}
		static void PrintVowels2(string s) {
			int i = 0;
			while (i < s.Length) {
				if ("aeiou".IndexOf(s[i]) >= 0) {
					Console.WriteLine(s[i]);
				}
				i++;
			}
		}
	}
}