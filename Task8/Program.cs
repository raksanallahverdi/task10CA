namespace Task8
{
    public static class Program
    {
        public static void Main()
        {
            Library Library1 = new Library("The Hogwarts library");
            Book HaryPotterSeries = new Book("HP with cursed child", "fantasy", "Jane Rowling");
            Book Book1 = new Book("The Dark Sun", "fantasy", "Richard Rhodes");
            Library1.AddBook(HaryPotterSeries);
            Library1.AddBook(Book1);
            Library1.RemoveBook(Book1);
            Library1.GetDetails();

        }
    }
}

