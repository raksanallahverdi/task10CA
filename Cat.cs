using System;
namespace _11mayLesson
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string breed, string color) : base(name, age, breed, color)
        {

        }
        public override string GetVoice()
        {
            return $"{Name} makes voice like miyauuu ";
        }
    }
}

