using System.Collections.Generic;

namespace RPGKit.FantasyNameGenerator.Generators
{
    public class CompositeNameGenerator : INameGenerator
    {
        private List<INameGenerator> _nameGenerators;

        public Gender Gender { get; set; }
        public INameGenerator PrefixGenerator { get; set; }
        public INameGenerator FirstNameGenerator { get; set; }
        public INameGenerator LastNameGenerator { get; set; }
        public INameGenerator PostfixNameGenerator { get; set; }
        public INameGenerator LandNameGenerator { get; set; }

        #region INameGenerator implementation
        public FantasyName GetFantasyName()
        {
            FantasyName name = new FantasyName();

            name.Gender = this.Gender;

            if (PrefixGenerator != null)
                name.Prefix = PrefixGenerator.GetName();

            if (FirstNameGenerator != null)
                name.FirstName = FirstNameGenerator.GetName();

            if (LastNameGenerator != null)
                name.LastName = LastNameGenerator.GetName();

            if (PostfixNameGenerator != null)
                name.Postfix = PostfixNameGenerator.GetName();

            if (LandNameGenerator != null)
                name.Land = LandNameGenerator.GetName();

            return name;
        }

        public string GetName()
        {
            string fullName = string.Empty;
            foreach (INameGenerator gen in _nameGenerators)
            {
                fullName += " " + gen.GetName();
            }

            return fullName.TrimEnd();
        }
        #endregion

        public CompositeNameGenerator(Gender gender, List<INameGenerator> nameGenerators)
        {
            this.Gender = gender;
            _nameGenerators = nameGenerators;
        }

        public CompositeNameGenerator(bool useDefaultSettings)
        {
            _nameGenerators = new List<INameGenerator>();

            if (useDefaultSettings)
            {

                _nameGenerators.Add(new PrefixGenerator());
                _nameGenerators.Add(new MaleWarriorFirstNameGenerator());
                _nameGenerators.Add(new LastNameGenerator());
                _nameGenerators.Add(new PostfixGenerator());
                _nameGenerators.Add(new LandGenerator());
            }
        }

        public void AddNameGenerator(INameGenerator nameGenerator)
        {
            _nameGenerators.Add(nameGenerator);
        }
    }
}
