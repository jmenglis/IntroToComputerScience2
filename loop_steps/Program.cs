using System;

namespace IntroCS {
	class LoopSteps {
		static void Main() {
			string s = "abcd";
			int i = 1;
			while (i < 4) {
				Console.Write("/" + s[i] + s[i - 1]);
				i++;
			}
			Console.WriteLine();
		}
	}
}