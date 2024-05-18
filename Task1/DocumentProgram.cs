using System;
namespace Task1
{
	public class DocumentProgram
	{
		
		public DocumentProgram()
		{
		
			
		}
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        public virtual void SaveDocument(string format)
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }


    }
}

