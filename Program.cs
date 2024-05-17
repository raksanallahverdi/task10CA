//sealed override elediyin metodu sealed elemisense 
//derive base
//virtual override
//protected ozunden miras alan claslarda gorue biler
//private
//polymorpsm override(compile time) overload(runtime)
//override sadece body deyishir
//dma private public protected
//abstract clasdan obyekt yaratmaq olmur,bodysi yoxdur
//konkret class ichinde abstact method yaza bilmerik



namespace _11mayLesson
{
    public static class Program
    {
        public static void Main()
        {
            Dog Cherry = new Dog("Cherry",2,"puppy","red");
            Console.WriteLine(Cherry.GetVoice());
            Cat Darla = new Cat("Darla", 1, "spanish cat", "white");
            Console.WriteLine(Darla.GetVoice()) ;

        }
    }
}