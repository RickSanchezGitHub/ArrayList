using Core;
using NUnit.Framework;

namespace ArrayListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5}, 5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 6 }, 6)]
        [TestCase(new int[] { }, new int[] { 5 }, 5)]
        public void AddLastTest(int[] array, int[] expectedArray, int add)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddLast(add);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]

        public void AddLastArrayListTest(int[] array, int[] expectedArray, int[] addArrayTest)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            ArrayList addArray = new ArrayList(addArrayTest);
            actual.AddLast(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3, 4 }, 5)]
        public void AddFirstTest(int[] array, int[] expectedArray, int add)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(add);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]
        [TestCase(new int[] { 1 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 1 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]
        [TestCase(new int[] { 1, 2, 3, 4, 23, 324, 23, 34, 34 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 23, 324, 23, 34, 34 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]
        public void AddArrayListFirstTest(int[] array, int[] expectedArray, int[] addArrayTest)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            ArrayList addArray = new ArrayList(addArrayTest);
            actual.AddFirst(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 4, 5, 32, 5 }, new int[] { 1, 4, 5, 5, 32, 5 }, 3, 5)]
        public void AddAtTest(int[] array, int[] expectedArray, int index, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddAt(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 4, 5, 32, 5 }, new int[] { 1, 4, 5, 1, 3, 5, 32, 5 }, 3, new int[] { 1, 3, 5 })]
        [TestCase(new int[] { 1, 4, 5, 32, 5, 5, 4, 666, 4, 6, 4, 5 }, new int[] { 1, 3, 5, 1, 4, 5, 32, 5, 5, 4, 666, 4, 6, 4, 5 }, 0, new int[] { 1, 3, 5 })]
        [TestCase(new int[] { 1, 4, 5, 32, 5, 5, 4, 666, 4, 6, 4, 5 }, new int[] { 1, 4, 5, 32, 5, 5, 4, 666, 4, 6, 4, 5, 1, 3, 5 }, 12, new int[] { 1, 3, 5 })]

        public void AddAtArrayListTest(int[] array, int[] expectedArray, int index, int[] addArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            ArrayList add = new ArrayList(addArray);
            actual.AddAt(index, add);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 4, 5, 32, 5 }, 32)]
        [TestCase(new int[] { 32, 5, 5, 4, 666, 4, 6, 4, }, 666)]
        public void MaxTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.Max();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 4, 5, 32, 5 }, 1)]
        [TestCase(new int[] { 32, 5, 5, 4, 666, 4, 2, 4, }, 2)]
        public void MinTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.Min();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 4, 5, 32, 5 }, 3)]
        [TestCase(new int[] { 32, 5, 5, 4, 666, 4, 2, 4, }, 4)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.IndexOfMax();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 4, 5, 32, 5 }, 0)]
        [TestCase(new int[] { 32, 5, 5, 4, 666, 4, 2, 4, }, 6)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.IndexOfMin();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 6, 7 }, new int[] { 1, 5, 6 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveLastTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveLast();
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 6, 7 }, new int[] { 5, 6, 7 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirstTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFirst();
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4 }, 3)]
        public void RemoveFirstMultipleTest(int[] array, int[] expectedArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveLastMultiple(index);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6 }, 3)]
        public void RemoveLastMultipleTest(int[] array, int[] expectedArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveFirstMultiple(index);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 5, 6 }, 3)]
        public void RemoveAtTest(int[] array, int[] expectedArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveAt(index);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 6 }, 3, 2)]
        public void RemoveAtMultipleTest(int[] array, int[] expectedArray, int index, int n)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveAtMultiple(index, n);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 2, 2, 6, 7 }, 2, 2)]
        [TestCase(new int[] { 1 }, 1, 0)]
        public void RemoveFirstValTest(int[] array, int val, int expectedIdx)
        {
            ArrayList actual = new ArrayList(array);
            int actualIdx = actual.RemoveFirst(val);
            Assert.AreEqual(actualIdx, expectedIdx);
        }
        [TestCase(new int[] { 1, 5, 2, 2, 6, 7 }, 2, 2)]
        [TestCase(new int[] { 1 }, 1, 1)]
        public void RemoveAllTest(int[] array, int val, int expectedIdx)
        {
            ArrayList actual = new ArrayList(array);
            int actualIdx = actual.RemoveAll(val);
            Assert.AreEqual(actualIdx, expectedIdx);
        }
        [TestCase(new int[] { 1, 5, 2, 2, 6, 7 }, 2, true)]
        [TestCase(new int[] { 1 }, 0, false)]
        public void ContainsTest(int[] array, int val, bool expected)
        {
            ArrayList actualArray = new ArrayList(array);
            bool actual = actualArray.Contains(val);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 1, 2, 6, 7 }, 2, 3)]
        public void IndexOfTest(int[] array, int val, int expectedIdx)
        {
            ArrayList actual = new ArrayList(array);
            int actualIdx = actual.IndexOf(val);
            Assert.AreEqual(actualIdx, expectedIdx);
        }
        [TestCase(new int[] { 1, 5, 1, 2, 6, 7 }, 1)]
        public void GetFirstTest(int[] array, int expected)
        {
            ArrayList actualArray = new ArrayList(array);
            int actual = actualArray.GetFirst();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 1, 2, 6, 7, 666 }, 666)]
        public void GetLastTest(int[] array, int expected)
        {
            ArrayList actualArray = new ArrayList(array);
            int actual = actualArray.GetLast();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 1, 2, 6, 7 }, 2, 1)]
        public void GetTest(int[] array, int Idx, int expected)
        {
            ArrayList actualArray = new ArrayList(array);
            int actual = actualArray.Get(Idx);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 1, 2, 6, 7, 666 }, 7)]
        public void GetLengthTest(int[] array, int expected)
        {
            ArrayList actualArray = new ArrayList(array);
            int actual = actualArray.GetLength();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 9, 4 }, 2, 9)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 2, 3, 4, 5 }, 0, 4)]

        public void SetTest(int[] array, int[] expectedArray, int idx, int val)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Set(idx, val);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]

        public void ToArrayTest(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]

        public void ReverseTest(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 2, 1, 5, 4 }, new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 3, 2, 5, 4, 7 }, new int[] { 2, 3, 4, 5, 7 })]

        public void SortTest(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Sort();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 2, 1, 5, 4 }, new int[] { 5, 4, 2, 1 })]
        [TestCase(new int[] { 3, 2, 5, 4, 7 }, new int[] { 7, 5, 4, 3, 2 })]

        public void SortDescTest(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.SortDesc();
            Assert.AreEqual(expected, actual);
        }
    }
}