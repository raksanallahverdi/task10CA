using System;
namespace _11mayLesson
{
	public abstract class Animal
	{
		public string Name{ get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
		public string Color { get; set; }
        

        public Animal(string name,int age, string breed, string color)
		{

        this.Name=name;
        this.Age=age;
        this.Breed=breed;
        this.Color=color;

    }
        public abstract string GetVoice();
		

	}
}

