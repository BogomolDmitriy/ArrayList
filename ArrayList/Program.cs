using System;
using ArrayListLibrary1;

namespace ArrayListMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList proba1 = new ArrayList();
            proba1.Add1(1);
            proba1.Add1(3);
            proba1.Add1(7);
            proba1.Add1(9);
            proba1.Add1(5);
            proba1.Add1(2);
            proba1.Add1(1);
            proba1.sortAscending19();
            proba1.Print();
        }
    }
}
