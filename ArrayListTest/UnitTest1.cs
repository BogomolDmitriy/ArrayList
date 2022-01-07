using NUnit.Framework;
using ArrayListLibrary1;

namespace ArrayListTest
{
    public class Tests
    {

        [TestCase (new[] { 1, 2 ,3, 4, 5, 6, 7, 8, 9, 10})]
        [TestCase(new[] {1})]
        [TestCase(new[] { -1, 8, 7, 4, -5})]
        [TestCase(new[] { 5981952, 655662, 3654 })]
        [TestCase(new[] { 0 })]
        public void AddBack_WhenElementsByElementAdded_ShouldFillArray ( int [] sourceArray)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.Adding1(sourceArray[i]);
            }

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(sourceArray[i], arrayList[i]);
            }
        }


    }
}