using System;
namespace _11mayLesson
{
	public class Dog:Animal
	{
		public Dog(string name,int age,string breed,string color):base(name,age,breed,color)
		{
			
		}
        public override string GetVoice()
		{
			return $"{Name} is barking,hav hav";
		}
    }
}

