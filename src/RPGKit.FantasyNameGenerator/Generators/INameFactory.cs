using System;

namespace RPGKit.FantasyNameGenerator
{
	public interface INameFactory
	{
		/*string[] GetNames(int numNames);*/
		FantasyName[] GetFantasyNames(int numNames);
	}
}
