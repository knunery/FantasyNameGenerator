using System.Collections.Generic;

namespace RPGKit.FantasyNameGenerator
{
	public class PostfixWizardGenerator:NameGenerator, INameGenerator
	{
        private static readonly List<string> _postfixes = new List<string>() { "Abjurer", "Black Mage", "Blue Mage", "Conjurer", "Dark Wizard", "Diviner", "Elementalist", "Enchanter", "Illusionist", "Mage", "Magician", "Necromancer", "Red Mage", "Sorcerer", "Summoner", "Transmuter", "Warlock" };
		
		#region INameGenerator implementation
		public string GetName ()
		{
			int length = _postfixes.Count;
			return "the " + _postfixes[GetRandomNumber(length)];
		}
		
		#endregion
	}
}
