using System;
using ArrayListLibrary1;

namespace ArrayListMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList proba1 = new ArrayList();
            proba1.AddEnd(1);
            proba1.AddEnd(2);
            proba1.AddEnd(3);
            proba1.AddEnd(4);
            proba1.AddEnd(5);
            proba1.AddEnd(6);
            proba1.DeleteIndex( 0 );
            proba1.Print();
        }
    }
}
