using System;

namespace RPGKit.FantasyNameGenerator
{
	public class VilePostfixGenerator : NameGenerator, INameGenerator
	{
		private string[] _namePostfixes;
		
		public VilePostfixGenerator()
		{
			_namePostfixes = new string[] { "Unholy", "Crazed", "Terrible", "Cruel", "Gruesome", "Boneless", "Gnarled", "Broken", "Underhanded", "Scalper", "Tormented"};				
		}

		public string GetName ()
		{
			return "the " + GetRandomElement (_namePostfixes);
		}		
	}
	

	public class PostfixGenerator : NameGenerator, INameGenerator
	{
		private string[] _namePostfixes;
		
		public PostfixGenerator()
		{
			_namePostfixes = new string[] { "the Virtuous", "the Valiant", "the Unholy", "the Holy", "the Fierce", "the Golden", "the Bold", "the Brash", "the Crazed", "the Great",
		"the Terrible", "the Cruel", "the Destroyer", "the Magnificent", "the Brave", "the Cowardly", "the Mighty", "the One", "the Unavoidable", "the Lion",
		"the Pious", "I", "II", "III", "IV", "V", "the Black", "the Red", "the Good", "the Boneless",
		"the Great King", "the Restless", "the Peaceful", "the Traveled", "the Deposed" };				
		}

		public string GetName ()
		{
			return GetRandomElement (_namePostfixes);
		}
		
	}
}
