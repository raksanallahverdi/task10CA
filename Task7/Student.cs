﻿using System;
namespace Task7
{
	public class Student
	{
		public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name,string surname)
		{
			Name = name;
			Surname = surname;
		}
		public void GetDetails()
		{
			Console.WriteLine($"{Name} {Surname}");

		}
	}
}

