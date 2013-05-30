using System;

namespace RPGKit.FantasyNameGenerator
{

	public class MaleRogueFirstNameGenerator : NameGenerator, INameGenerator
	{
		public static string[] Rogue_FirstNames = new string[] { "Slinter", "Despar", "Trixster", "Rostor", "Grasdo", "Rendar", "Sole", "Pington", "Glodstar", "Denton","Slipert", "Mistrewn", "Liard" };
		
		public static string[] Rogue_FirstNamesPart1 = new string[] { "Deca", "Evi", "Hideo", "Sli", "Quici", "Sly", "Miser" };
		public static string[] Rogue_FirstNamesPart2 = new string[] { "terous", "nton", "slip", "pask", "gold", "ck", "plone", "plast", "nturous" };
		
		#region INameGenerator implementation
		public string GetName ()
		{
			int weight = GetWeight();
			if(weight < 15)
				return GetRandomElement(Rogue_FirstNames);
			else
				return GetRandomElement(Rogue_FirstNamesPart1) + GetRandomElement(Rogue_FirstNamesPart2);
		}		
		#endregion
	}
}
