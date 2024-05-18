
using System;
namespace Task1
{
    public static class Program
    {
        public static void Main()

        {
           signmark:
            Console.WriteLine("Basic,Pro or Expert User?");
            string keyword = Console.ReadLine();

            switch (keyword)
            {
                case "basic":
                    DocumentProgram documentprogram = new DocumentProgram();
                    documentprogram.OpenDocument();
                    documentprogram.EditDocument();
                    documentprogram.SaveDocument("xs");
                    break;
                case "pro":
                    ProDocumentProgram prodocumentprogram = new ProDocumentProgram();
                    prodocumentprogram.OpenDocument();
                    prodocumentprogram.EditDocument();
                    prodocumentprogram.SaveDocument("pdf");
                    break;
                case "expert":
                    ExpertDocumentProgram expertdocumentprogram = new ExpertDocumentProgram();
                    expertdocumentprogram.OpenDocument();
                    expertdocumentprogram.EditDocument();
                    expertdocumentprogram.SaveDocument("doc");
                    break;
                default:
                    goto signmark;


            }
        }
    }
}


