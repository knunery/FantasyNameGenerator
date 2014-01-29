![RPGKit - FantasyNameGenerator](https://raw.github.com/knunery/FantasyNameGenerator/master/rpgkit.jpg)

RPG Kit - Fantasy Name Generator
====================

A random name generator for fantasy characters.  This very same code is used in the iPhone and Windows Phone application called RPG Kit.

How to use?
===========

Here is how you would get 10 random male warrior fantasy names.


    var fantasyNameSettings = new FantasyNameSettings(Classes.Warrior,Race.None, true, true, Gender.Male);
    IFantasyNameGenerator fantasyNameGenerator = FantasyNameGenerator.FromSettingsInfo( fantasyNameSettings );
    FantasyName[] names = fantasyNameGenerator.GetFantasyNames(10);
