using System;
namespace Task1
{
	public class ProDocumentProgram:DocumentProgram
	{



		public ProDocumentProgram()
		{

          
    }
        public sealed override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }
        public override void SaveDocument(string format)
        {
            Console.WriteLine("Document Saved in pdf format");
        }



    }
}

