using System;
using System.Collections.Generic;

namespace RPGKit.FantasyNameGenerator
{
	public class PostfixWizardGenerator:NameGenerator, INameGenerator
	{
        private static readonly List<string> _postfixes = new List<string>() { "Abjurer", "Black Mage", "Blue Mage", "Conjurer", "Dark Wizard", "Diviner", "Elementalist", "Enchanter", "Illusionist", "Mage", "Magician", "Necromancer", "Red Mage", "Sorcerer", "Summoner", "Transmuter", "Warlock" };
		//public static string[] Wizard_Postfixes = new string[] {};
		// conjurer, sorcerer, sorceress, wizard, transmuter, magician, necromancer, mage, enchanter, alchemist, diviner, abjurer, sage, warlock, illusionist, diviner
		#region INameGenerator implementation
		public string GetName ()
		{
			int length = _postfixes.Count;
			return "the " + _postfixes[GetRandomNumber(length)];
		}
		
		#endregion
	}
}
