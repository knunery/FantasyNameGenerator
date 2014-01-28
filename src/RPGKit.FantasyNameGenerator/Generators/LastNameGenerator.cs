namespace RPGKit.FantasyNameGenerator
{
	public class LastNameGenerator : NameGenerator, INameGenerator
	{
		public static string[] LastNamesPart1 = new string[] { "Black", "Dread", "Flame", "Doom", "Iron", "Blood", "Smoke", "Grim" };
		public static string[] LastNamesPart2 = new string[] { "hunter", "bite", "mist", "sinner", "bone", "moon", "rule", "murk", "lust", "heart" };
		
		public string GetName()
		{
			return GetRandomElement(LastNamesPart1) + GetRandomElement(LastNamesPart2);
		}
	}
}
