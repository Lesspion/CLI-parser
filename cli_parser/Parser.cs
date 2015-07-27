using System;
using System.Collections.Generic;

namespace cli_parser
{
	public static class Parser
	{
		private string[] unsortedArgs;

		private Dictionnary<string, string> sortArgs = new Dictionnary<string, string>();

		public static void analysis(string[] args)
		{
			this.unsortedArgs = args;
			foreach (int curArg in args)
			{
				if (curArg % 2 == 0) {
					this.sortArgs.Add(curArg, args[curArg + 1]);
				} else {
					continue;
				}
			}
		}

		public static Dictionnary<string, string> getArgs()
		{
			return this.sortArgs;
		}

	}
}
