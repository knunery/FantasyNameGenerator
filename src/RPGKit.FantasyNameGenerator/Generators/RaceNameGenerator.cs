using System;
using System.Collections.Generic;


namespace RPGKit.FantasyNameGenerator
{
	public class RaceNameGenerator : NameGenerator, INameGenerator
	{
	    private int _raceId;

        private static readonly List<string> goblinNames = new List<string>() {"ach","adz","ak","ark","az","balg","bilg","blid","blig","blok","blot","bolg","bot","bug","burk","dokh","drik","duf","ga","gad","glak","gluf","ghag","ghak","gat","git","glok","gnat","gunk","gurk","likk","loz","luk","mak","maz","miz","mub","nad","nag","naz","nig","nikk","nogg","nok","nukk","rag","rake","rat","rok","shrig","shuk","skrag","skung","slig","slug","slog","snag","snart","snat"};
        private static readonly List<string> orcNames = new List<string>() { "ag", "aug", "bad", "bag", "bakh", "bruz", "dag", "dakk", "darg", "ghaz", "glakh", "glaz", "glob", "gob", "gokh", "gol", "golk", "grub", "grud", "gud", "gut", "khar", "krag", "krud", "lakh", "molk", "muk", "muz", "nar", "rot", "rud", "ruft", "rug", "skar", "skulg", "slur", "snar", "trog", "ug", "umsh", "ung" };

	    private static readonly List<List<string>> raceNames = new List<List<string>>() {new List<string>(), goblinNames, orcNames};

        public RaceNameGenerator (int raceid)
        {
            _raceId = raceid;
        }// end ctr

		public string GetBeginPart()
		{
		    List<string> names = raceNames[_raceId];

            string namePart = names[GetRandomNumber(names.Count)];
			return namePart[0].ToString().ToUpper() + namePart.Substring(1);
		}
		
		public string GetEndPart()
		{
            List<string> names = raceNames[_raceId];

            return names[GetRandomNumber(names.Count)];
		}

		#region INameGenerator implementation
		public string GetName ()
		{
			return GetBeginPart() + GetEndPart();
		}
		#endregion
	}
}

