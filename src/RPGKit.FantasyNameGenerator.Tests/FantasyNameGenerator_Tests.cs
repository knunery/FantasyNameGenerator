using ApprovalTests.Reporters;
using NUnit.Framework;
using RPGKit.FantasyNameGenerator.Generators;

namespace RPGKit.FantasyNameGenerator.Tests
{
    public class FantasyNameGenerator_Tests
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void Male_Warrior()
        {
            // arrange
            NameGenerator.GetRandomNumber = (maxValue) => 1;
            IFantasyNameGenerator fantasyNameGenerator = FantasyNameGenerator.FromSettingsInfo(new SettingsInfo(Classes.Warrior, Race.None, true, true, Gender.Male));

            // act
            var names = fantasyNameGenerator.GetFantasyNames(2);

            // assert
            ApprovalTests.Approvals.VerifyAll("Male Warrior Names", names, "names");
        }

        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void Female_Goblin_Warrior()
        {
            // arrange
            NameGenerator.GetRandomNumber = (maxValue) => 1;
            IFantasyNameGenerator fantasyNameGenerator = FantasyNameGenerator.FromSettingsInfo(new SettingsInfo(Classes.Warrior, Race.Goblin, true, true, Gender.Female));

            // act
            var names = fantasyNameGenerator.GetFantasyNames(2);

            // assert
            ApprovalTests.Approvals.VerifyAll("Female Goblin Names", names, "names");
        }
    }
}
