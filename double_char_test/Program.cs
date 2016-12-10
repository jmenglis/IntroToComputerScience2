using System;

namespace IntroCS {
	class DoubleCharTest {
		static void Main() {
			string s = UIF.PromptLine("Enter Line Here: ");
			Console.Write(HasDoubleChar(s));
		}
		static bool HasDoubleChar(string s) {
			int i = 1;
			while (i < s.Length) {
				if(s[i] == s[i - 1]) {
					return true;
				}
				i++;
			}
			return false;
		}
	}
}