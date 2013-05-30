![RPGKit - FantasyNameGenerator](https://raw.github.com/knunery/FantasyNameGenerator/master/rpgkit.jpg)

FantasyNameGenerator
====================

A random name generator for fantasy characters.

How to use?
===========

Here is how you would get 10 male warrior fantasy names.

  > NameFactory nameFactory = new NameFactory(new SettingsInfo(Classes.Warrior, Race.None, true, true, GenderEnum.Male));
  > var names = nameFactory.GetFantasyNames(10);
