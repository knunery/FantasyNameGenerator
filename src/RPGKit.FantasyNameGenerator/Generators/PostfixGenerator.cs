namespace RPGKit.FantasyNameGenerator.Generators
{
	public class VilePostfixGenerator : NameGenerator
	{
		private string[] _namePostfixes;
		
		public VilePostfixGenerator()
		{
			_namePostfixes = new string[] { "Unholy", "Crazed", "Terrible", "Cruel", "Gruesome", "Boneless", "Gnarled", "Broken", "Underhanded", "Scalper", "Tormented"};				
		}

		public override string GetName ()
		{
			return "the " + GetRandomElement (_namePostfixes);
		}		
	}
	

	public class PostfixGenerator : NameGenerator
	{
		private string[] _namePostfixes;
		
		public PostfixGenerator()
		{
			_namePostfixes = new string[] { "the Virtuous", "the Valiant", "the Unholy", "the Holy", "the Fierce", "the Golden", "the Bold", "the Brash", "the Crazed", "the Great",
		"the Terrible", "the Cruel", "the Destroyer", "the Magnificent", "the Brave", "the Cowardly", "the Mighty", "the One", "the Unavoidable", "the Lion",
		"the Pious", "I", "II", "III", "IV", "V", "the Black", "the Red", "the Good", "the Boneless",
		"the Great King", "the Restless", "the Peaceful", "the Traveled", "the Deposed" };				
		}

		public override string GetName ()
		{
			return GetRandomElement (_namePostfixes);
		}
		
	}
}
