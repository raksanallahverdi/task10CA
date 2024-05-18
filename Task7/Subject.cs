using System;
namespace Task7
{
    public class Subject
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Subject(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Type}");
        }
    }
}

