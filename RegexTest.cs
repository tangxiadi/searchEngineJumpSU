// A Hello World! program in C#.
using System;
using System.Text.RegularExpressions;
namespace Main
{
	class main 
	{
		static void Main() 
		{
			string[] test = new string[] {
			"https://www.yandex.com/search/?text=q&lr=200",
			"https://www.yandex.com/search/?msid=22881.3561.1459856698.53966&text=a&suggest_reqid=270699930145985644966994568781974&lr=200",
			"https://www.yandex.ru/search/?text=q&lr=200",
			"https://www.yandex.com/search/?text=q"
			};

			Regex reg = new Regex(@"^https?:\/\/(www\.)?yandex\..+\/search\/\?(.+&)?text=");
			int i=0;
			foreach (string s in test)
			{
				i++;
				Console.WriteLine(i + " , " + reg.IsMatch(s) + " , \"" + reg.Match(s) + "\"\n");
			}
			//Console.ReadKey();
		}
	}
}