using System;
namespace Task8
{
	public class Book
	{
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public Book(string name, string genre, string author)
		{
            Name = name;
            Genre = genre;
            Author = author;
        }
        public void GetDetails()
        {
            Console.WriteLine($" Book name: {Name} , Book genre: {Genre}, Book author: {Author}");
        }
    }
}

