using ApprovalTests.Reporters;
using NUnit.Framework;
using RPGKit.FantasyNameGenerator.Generators;

namespace RPGKit.FantasyNameGenerator.Tests
{
    class FantasyNameGenerator_Tests
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void Male_Warrior()
        {
            NameGenerator.GetRandomNumber = (maxValue) => 1;

            NameFactory nameFactory = new NameFactory(new SettingsInfo(Classes.Warrior, Race.None, true, true, GenderEnum.Male));

            var names = nameFactory.GetFantasyNames(2);

            ApprovalTests.Approvals.VerifyAll("Male Warrior Names", names, "names");
        }

        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void Female_Goblin_Warrior()
        {
            NameGenerator.GetRandomNumber = (maxValue) => 1;
            NameFactory nameFactory = new NameFactory(new SettingsInfo(Classes.Warrior, Race.Goblin, true, true, GenderEnum.Female));

            var names = nameFactory.GetFantasyNames(2);

            ApprovalTests.Approvals.VerifyAll("Female Goblin Names", names, "names");
        }
    }
}
