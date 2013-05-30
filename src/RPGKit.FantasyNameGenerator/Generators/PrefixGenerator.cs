using System;

namespace RPGKit.FantasyNameGenerator
{
	public class PrefixGenerator : NameGenerator, INameGenerator
	{
		public static string[] NamePrefix = new string[] { "Sir" };	
		
		public string GetName ()
		{
			return GetRandomElement(NamePrefix);
		}
	}
}
