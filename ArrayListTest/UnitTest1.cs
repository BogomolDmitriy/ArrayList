using NUnit.Framework;
using ArrayListLibrary1;

namespace ArrayListTest
{
    public class Tests
    {
        //Task 1
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
                arrayList.AddEnd(sourceArray[i]);
            }

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(sourceArray[i], arrayList[i]);
            }
        }

        //Task 2
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7}, 8, new[] {8, 1, 2, 3, 4, 5, 6, 7})]
        [TestCase(new[] { 1 }, 8, new[] { 8, 1})]
        [TestCase(new[] { -1, 2, 563, -34, 0}, 8, new[] {8, -1, 2, 563, -34, 0})]
        [TestCase(new[] { 6, 0, 4}, 0, new[] { 0, 6, 0, 4 })]
        [TestCase(new[] { 6, 0, 4, 7, 8, -76, 987, -1, 0, 786 }, 0, new[] { 0, 6, 0, 4, 7, 8, -76, 987, -1, 0, 786 })]
        [TestCase(new[] { 0 }, 8, new[] { 8, 0 })]

        public void AddStart_AddingAValueToTheBeginning (int[] sourceArray, int value, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.AddStart(value);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 3
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 8, new[] { 1, 2, 8, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 9, 2, 3, -7, 5, 0, 7 }, 0, 8, new[] { 8, 9, 2, 3, -7, 5, 0, 7 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 7, 8, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new[] { 1 }, 0, 8, new[] { 8, 1 })]
        [TestCase(new[] { 0 }, 0, 0, new[] { 0, 0 })]

        public void AddIndex_AddingValueByIndex (int[] sourceArray, int index, int value, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.AddIndex(index, value);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 4
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new[] { 8, 8 }, new[] { 8 })]

        public void DeleteEnd_RemovingFromTheEndOfOneElement (int[] sourceArray, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.DeleteEnd();

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 5
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 0, 8 }, new[] { 8 })]

        public void DeleteStart_RemoveFromTheBeginningOfOneElement (int[] sourceArray, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.DeleteStart();

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 6
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 0, new[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 6, new[] { 1, 2, 3, 4, 5, 6, })]
        [TestCase(new[] { -1, 0, 65 }, 1, new[] { -1, 65 })]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, 3, new[] { 0, 0, 0, 0 })]

        public void DeleteIndex_BeletingByIndexOfOneElement (int[] sourceArray, int index, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.DeleteIndex(index);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 7
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 0, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 8, -2, 0, 4, 854, 3, 7 }, 2, new[] { 8, -2, 0, 4, 854 })]
        [TestCase(new[] { 8, -2, 0, 4, 854, 3, 7 }, 6, new[] { 8 })]

        public void deleting_N_ElementsFromTheEnd (int[] sourceArray, int N, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.removing_N_ElementsFromTheEnd(N);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 8
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 0, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 8, -2, 0, 4, 854, 3, 7 }, 2, new[] { 0, 4, 854, 3, 7 })]
        [TestCase(new[] { 8, -2, 0, 4, 854, 3, 7 }, 6, new[] { 7 })]

        public void deleting_N_ElementsFromTheStart (int[] sourceArray, int N, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.removing_N_ElementsFromTheStart(N);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 9
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 1, 3, new[] { 1, 5, 6, 7 })]
        [TestCase(new[] { 8, 84, -54, 46, 0, 54 }, 1, 2, new[] { 8, 46, 0, 54 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 0, 3, new[] { 4, 5, 6, 7 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, 4, new[] { 1, 2, 3 })]
        [TestCase(new[] { 8, 4, 1, 9, 547, -5, 78, 0 }, 1, 7, new[] { 8 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 7, new[] { 1, 9 })]

        public void deleting_N_ElementsFromTheIndex(int[] sourceArray, int index, int N, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.removing_N_ElementsFromTheIndex(index, N);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 13
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 1, 8, new[] { 1, 8, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 9, 10, 33, 4, 7, -1, 9 }, 2, 185, new[] { 9, 10, 185, 4, 7, -1, 9 })]
        [TestCase(new[] { 9, 10, 33, 4, 7, -1, 9 }, 0, 0, new[] { 0, 10, 33, 4, 7, -1, 9 })]
        [TestCase(new[] { 9, 10, 33, 4, 7, -1, 9 }, 6, 0, new[] { 9, 10, 33, 4, 7, -1, 0 })]

        public void ChangeByIndex (int[] sourceArray, int index, int number, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.changeByIndex(index, number);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 14
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { -78, 9, 0, 567, 1, 2 }, new[] { 2, 1, 567, 0, 9, -78 })]

        public void ArrayReverse (int[] sourceArray, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.reverse();

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 15
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 7)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 85, 0, 847, 67, -58 }, 847)]
        [TestCase(new[] { -58, -4, -584, -86 }, -4)]
        [TestCase(new[] { -58, -4, -584, 0, -86 }, 0)]

        public void FindTheValueOfTheMaximumElement (int[] sourceArray, int expected)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            int actual = arrayList.valueMax();
            Assert.AreEqual (actual, expected);
        }

        //Task 16
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 1)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 85, 0, 847, 67, -58 }, -58)]
        [TestCase(new[] { -58, -4, -584, -86 }, -584)]
        [TestCase(new[] { 58, 4, 0, 86 }, 0)]

        public void FindTheValueOfTheMinimumElement (int[] sourceArray, int expected)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            int actual = arrayList.valueMin();
            Assert.AreEqual(actual, expected);
        }

        //Task 17
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 6)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 85, 0, 847, 67, -58 }, 2)]
        [TestCase(new[] { -58, -4, -584, -86 }, 1)]
        [TestCase(new[] { 58, 4, 0, 86 }, 3)]
        [TestCase(new[] { 598, 4, 0, 86 }, 0)]

        public void FindTheIndexOfTheMaximumElement (int[] sourceArray, int expected)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            int actual = arrayList.indexMax();
            Assert.AreEqual(actual, expected);
        }

        //Task 18
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 0)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 85, 0, 847, 67, -58 }, 4)]
        [TestCase(new[] { -58, -4, -584, -86 }, 2)]
        [TestCase(new[] { 58, 4, 0, 86 }, 2)]
        [TestCase(new[] { 598, 4, 0, 86, -654 }, 4)]

        public void FindingTheIndexOfTheMinimumElement (int[] sourceArray, int expected)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            int actual = arrayList.indexMin();
            Assert.AreEqual(actual, expected);
        }

        //Task 19
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { -78, 9, 0, 567, 1, 2 }, new[] { -78, 0, 1, 2, 9, 567 })]
        [TestCase(new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 })]

        public void SortingInAscendingOrder (int[] sourceArray, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.SortAscending();

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 20
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { -78, 9, 0, 567, 1, 2 }, new[] { 567, 9, 2, 1, 0, -78 })]
        [TestCase(new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 })]

        public void SortingInDescendingOrder (int[] sourceArray, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.SortDescending();

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 21
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 1, new[] { 1, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 4, 4, 3, 2, 1 }, 4, 0, new[] { 4, 3, 2, 1 })]
        [TestCase(new[] { 3, 4, 8, 7, 0 }, 0, 4, new[] { 3, 4, 8, 7 })]

        public void RemoveByValueOfFirst_ReturnIndex (int[] sourceArray, int NumberToRemove, int ExpectedIndex, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            int ReturnedIndex = arrayList.DeleteByValueFirstReturnIndex (NumberToRemove);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }

            Assert.AreEqual(ReturnedIndex, ExpectedIndex);
        }

        //Task 22
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 1, new[] { 1, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 4, 4, 3, 2, 1 }, 4, 2, new[] { 3, 2, 1 })]
        [TestCase(new[] { 3, 4, 8, 7, 0 }, 0, 1, new[] { 3, 4, 8, 7 })]
        [TestCase(new[] { 3, 3, 3, 3, 0, 3 }, 3, 5, new[] { 0 })]

        public void DeletingByValueOfAll_ReturnÑount (int[] sourceArray, int NumberToRemove, int ExpectedÑount, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            int ReturnedIndex = arrayList.DeleteByValueAll (NumberToRemove);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }

            Assert.AreEqual(ReturnedIndex, ExpectedÑount);
        }

        //Task 24
        [TestCase(new[] { 1, 2 }, new[] { 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 1 }, new[] { 88, 5, 54, 563, 7 }, new[] { 1, 88, 5, 54, 563, 7 })]
        [TestCase(new[] { 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        public void AddingAist_YourHomemade_ToTheEnd (int[] sourceArray, int[] AddArray , int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.AddingAListToTheEnd(AddArray);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 25
        [TestCase(new[] { 6, 7 }, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 1 }, new[] { 88, 5, 54, 563, 7 }, new[] { 88, 5, 54, 563, 7, 1 })]
        [TestCase(new[] { 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1 })]
        public void AddingAist_YourHomemade_ToTheBegining (int[] sourceArray, int[] AddArray, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.addingAListToTheBeginning(AddArray);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }

        //Task 26
        [TestCase(new[] { 6, 7 }, 1, new[] { 1, 2, 3, 4, 5 }, new[] { 6, 1, 2, 3, 4, 5, 7 })]
        [TestCase(new[] { 1 }, 0, new[] { 88, 5, 54, 563, 7 }, new[] { 88, 5, 54, 563, 7, 1 })]
        [TestCase(new[] { -16, 4, 5, 7, 9, 0, 67 }, 4, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new[] { -16, 4, 5, 7, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 9, 0, 67 })]
        [TestCase(new[] { 1, 88, 96, -1, 567 }, 0, new[] { 88, 5, 54, 563, 7 }, new[] { 88, 5, 54, 563, 7, 1, 88, 96, -1, 567 })]
        [TestCase(new[] { 1, 88, 96, -1, 567 }, 5, new[] { 88, 5, 54, 563, 7 }, new[] { 1, 88, 96, -1, 567, 88, 5, 54, 563, 7 })]
        public void AddingAist_YourHomemade_ToTheIndex (int[] sourceArray, int index, int[] AddArray, int[] ArrayResult)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddEnd(sourceArray[i]);
            }

            arrayList.AddListByIndex(index, AddArray);

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(arrayList[i], ArrayResult[i]);
            }
        }
    }
}