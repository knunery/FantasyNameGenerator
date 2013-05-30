using System;

namespace RPGKit.FantasyNameGenerator
{
    public abstract class NameGenerator
    {
        public static Func<int, int> GetRandomNumber = (maxValue) => { return _random.Next(maxValue); };
        //public static Func<Random> Random = () => { return new Random(); };
	    
		private static Random _random = new Random ();

		public NameGenerator () {}

		public string GetRandomElement (string[] array)
		{
		    int index = GetRandomNumber(array.Length);
		    return array[index];

		    //int index = _random.Next (array.Length);
		    //return array[index];
		}
		
        //public int GetRandomNumber(int maxValue)
        //{
        //    return _random.Next(maxValue);
        //}
		
		public int GetWeight()
		{
		    return GetRandomNumber(100);
		    //return _random.Next(100);			
		}
	}
}
