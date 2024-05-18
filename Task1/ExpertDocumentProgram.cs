using System;
namespace Task1
{
	public class ExpertDocumentProgram:ProDocumentProgram
	{
		public ExpertDocumentProgram()
		{
		}
        public override void SaveDocument(string format)
        {
            if (format == "pdf")
            {
                Console.WriteLine("Document Saved in pdf format");

            }
            else if (format == "doc")
            {
                Console.WriteLine("Document Saved in doc format");
            }
            else
            {
                Console.WriteLine("bele format yoxdu");
            }

        }
    }
}

