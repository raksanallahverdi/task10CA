using System;
namespace Task8
{
	public class Library
	{
		public string Name { get; set; }
		private Book[] books; 
		public Book[] Books {get=>books;}
		public int maxBookCount = 5;

		public Library(string name )
		{

			Name = name;
            books = new Book[0];
        }

		public void AddBook(Book book)
		{
			if (books.Length< maxBookCount)
			{
				Array.Resize(ref books, books.Length + 1);
				books[books.Length - 1] = book;
			}
			else
			{
				Console.WriteLine("Sorry,You have already reached the maximum number of books");
			}
		}

		public void RemoveBook(Book book)
		{
			int index = Array.IndexOf(books, book);
			if (index != -1)
			{
				for(int i=index; i < books.Length - 1; i++)
				{
					books[i] = books[i + 1];
				}
				Array.Resize(ref books, books.Length - 1);
			}
			else
			{
				Console.WriteLine("Sorry, We don't have this book");
			}
		}

		public void GetDetails()
		{
			foreach(var item in books)
			{
				item.GetDetails();
			}
			
		}
		


	}
}

