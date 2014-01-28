using System;
using RPGKit.FantasyNameGenerator.Generators;

namespace RPGKit.FantasyNameGenerator
{
	public class NameFactory : INameFactory
	{	
		public Classes ChosenClass { get; set; }
		public Race ChosenRace { get; set; }
		public bool IncludePrefix { get; set; }
		public bool IncludePostfix { get; set; }
		public bool IncludeLands { get; set; }
        public GenderEnum Gender { get; set; }

		public NameFactory ()
		{
			ChosenClass = Classes.Warrior;
			ChosenRace = Race.None;
			IncludePostfix = true;
			IncludeLands = true;
            Gender = GenderEnum.Male;
		}
		
		public NameFactory(SettingsInfo settingsInfo)
		{
			ChosenClass = settingsInfo.ChosenClass;
			ChosenRace = settingsInfo.ChosenRace;
			IncludeLands = settingsInfo.IncludeHomeland;
			IncludePostfix = settingsInfo.IncludePostfix;
		    Gender = settingsInfo.Gender;
		}

	    public FantasyName GetFantasyName()
	    {
	        return GetFantasyNames(1)[0];
	    }

	    public FantasyName[] GetFantasyNames(int numNames)
		{
			if (numNames < 0)
				throw new ArgumentException(string.Format("Number of fantasy names cannot be negative. [{0}",numNames));

			CompositeNameGenerator compositeNameGenerator = new CompositeNameGenerator(false);
			
            // TODO: use type matching/strategy pattern here or whatever you wanna call it.

	        compositeNameGenerator.Gender = this.Gender;
			// No prefix included in version 1
			//if(IncludePrefix)
			//	compositeNameGenerator.PrefixGenerator = new PrefixGenerator();
			
			if(ChosenClass != Classes.None)
			{
			    INameGenerator maleNameGenerator = null;

				if(ChosenClass == Classes.Cleric )
                    maleNameGenerator = new MaleClericFirstNameGenerator();

                if (ChosenClass == Classes.Rogue )
                    maleNameGenerator = new MaleRogueFirstNameGenerator();

                if (ChosenClass == Classes.Warrior )
                    maleNameGenerator = new MaleWarriorFirstNameGenerator();

                if (ChosenClass == Classes.Wizard )
                    maleNameGenerator = new MaleWizardFirstNameGenerator();
				
                if(Gender == GenderEnum.Male)
                {
                    compositeNameGenerator.FirstNameGenerator = maleNameGenerator;
                }
			    else
			    {
			        compositeNameGenerator.FirstNameGenerator = new FemaleWrapperNameGenerator(maleNameGenerator);
			    }

			    compositeNameGenerator.LastNameGenerator = new LastNameGenerator();
			}
			else
			{
				compositeNameGenerator.FirstNameGenerator = new RaceNameGenerator((int)ChosenRace);
				compositeNameGenerator.LastNameGenerator = new RaceNameGenerator((int)ChosenRace);
			}
            

	        if(IncludePostfix)
			{
				if(ChosenClass == Classes.Wizard)
					compositeNameGenerator.PostfixNameGenerator = new PostfixWizardGenerator();
				else if(ChosenRace != Race.None)
					compositeNameGenerator.PostfixNameGenerator = new VilePostfixGenerator();
				else
					compositeNameGenerator.PostfixNameGenerator = new PostfixGenerator();
			}
				
			if(IncludeLands)
				compositeNameGenerator.LandNameGenerator = new LandGenerator();
			
			FantasyName[] fantasyNames = new FantasyName[numNames];
			
			for(int i=0; i< numNames; i++)
			{
			    fantasyNames[i] = compositeNameGenerator.GetFantasyName();				
			}
			
			return fantasyNames;
		}
		
		
	}
}
