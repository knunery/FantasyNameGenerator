using RPGKit.FantasyNameGenerator.Generators;

namespace RPGKit.FantasyNameGenerator
{
    public class SettingsInfo
    {
        public Classes ChosenClass { get; set; }
        public Race ChosenRace { get; set; }
        public bool IncludeHomeland { get; set; }
        public bool IncludePostfix { get; set; }
        public Gender Gender { get; set; }

        public SettingsInfo(Classes chosenclass, Race race, bool includeHomeland, bool includePostfix, Gender gender)
        {
            ChosenClass = chosenclass;
            ChosenRace = race;
            IncludeHomeland = includeHomeland;
            IncludePostfix = includePostfix;
            Gender = gender;
        }

        public static SettingsInfo DefaultSettings()
        {
            return new SettingsInfo(Classes.Warrior, Race.None, true, true, Gender.Male);
        }

        public override string ToString()
        {
            return string.Format("[SettingsInfo: ChosenClass={0}, ChosenRace={1}, IncludeHomeland={2}, IncludePostfix={3}, Gender={4}]", ChosenClass, ChosenRace, IncludeHomeland, IncludePostfix, Gender);
        }
    }
}