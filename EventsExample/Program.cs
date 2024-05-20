using static System.Console;
using ClassLibrary1;
     class Program
    {
        static void Main()
        {
        SubcribedClass subcribedClass = new SubcribedClass();
        PublishedClass publishedclass = new PublishedClass();
        publishedclass.myEvent += subcribedClass.Add;
        publishedclass.RaiseEvent(10, 20);
        ReadKey();


        }
    }

