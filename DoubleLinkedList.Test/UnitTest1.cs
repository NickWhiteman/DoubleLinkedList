using NUnit.Framework;
using DoubleLinkedList;

namespace DoubleLinkedList.Test
{
    public class Tests
    {
        [TestCase(new int[] { 1, 2, 3 }, 1, 4, new int[] { 1, 4, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { }, 0, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, 4, new int[] { 4, 1 })]
        public void AddByIndex(int[] array, int index, int value, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })] 
        [TestCase(new int[] { 1, 2, 3, 4, 6, 8 }, 4, new int[] { 1, 2, 3, 4, 6, 8, 4 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2, 3, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 3 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 1, 0 })]
        public void Add(int[] array, int value, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })] 
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 0, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, new int[] { 3, 1, 2, 3 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 0, 1 })]
        public void AddByFirst(int[] array, int value, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.AddByFirst(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })] 
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void Remove(int[] array, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.Remove();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirst(int[] array, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.RemoveFirst();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 6, 1, 5, 0 }, 2, new int[] { 2, 6, 5, 0 })]
        [TestCase(new int[] { 1, 43, 35, 99, 23 }, 4, new int[] { 1, 43, 35, 99 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 1, new int[] { 23, -84, 34, 54 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, 3, new int[] { -23, -12, -45, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, 0, new int[] { })]
        public void RemoveByIndex(int[] array, int index, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetLength(int[] array, int expLength)
        {
            int expected = expLength;
            DoubleLL actual = new DoubleLL(array);

            int result = actual.GetLength();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void Reverse(int[] array, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, 5, new int[] { 1, 5, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 4, new int[] { 4, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, 8, new int[] { 1, 2, 8 })]
        [TestCase(new int[] { 1, 2, 3 }, 1, 10, new int[] { 1, 10, 3 })]
        [TestCase(new int[] { 1 }, 0, 2, new int[] { 2 })]
        public void ChangeIndex(int[] array, int index, int value, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.ChangeIndex(index, value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 99)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 54)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, 0)]
        public void GetMaxItem(int[] array, int expMax)
        {
            int expected = expMax;
            DoubleLL actual = new DoubleLL(array);

            int result = actual.GetMaxItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 1)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, -84)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, -45)]
        public void GetMinItem(int[] array, int expMin)
        {
            int expected = expMin;
            DoubleLL actual = new DoubleLL(array);

            int result = actual.GetMinItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 2)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 4)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, 4)]
        public void GetIndexMaxItem(int[] array, int expMax)
        {
            int expected = expMax;
            DoubleLL actual = new DoubleLL(array);

            int result = actual.GetIndexMaxItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 0)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 2)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, 1)]
        public void GetIndexMinItem(int[] array, int expMin)
        {
            int expected = expMin;
            DoubleLL actual = new DoubleLL(array);

            int result = actual.GetIndexMinItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, new int[] { 0, 1, 2, 5, 6 })]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, new int[] { 1, 23, 35, 43, 99 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, new int[] { -84, -12, 23, 34, 54 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, new int[] { -45, -23, -12, -1, 0 })]
        public void SortLayout(int[] array, int[] expArr)
        {
            DoubleLL expected = new DoubleLL(expArr);
            DoubleLL actual = new DoubleLL(array);

            actual.SortLayout();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 3, 1 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, new int[] { 6, 5, 2, 1, 0 })]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, new int[] { 99, 43, 35, 23, 1 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, new int[] { 54, 34, 23, -12, -84 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, new int[] { 0, -1, -12, -23, -45 })]
        public void SortDecrease(int[] array, int[] expArr)
        {
            DoubleLL expected = new DoubleLL(expArr);
            DoubleLL actual = new DoubleLL(array);

            actual.SortDecrease();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 1, 3 })]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, 5, new int[] { 2, 6, 1, 0 })]
        [TestCase(new int[] { 1, 43, 35, 99, 23 }, 99, new int[] { 1, 43, 35, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, -12, new int[] { 23, -84, 34, 54 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, 0, new int[] { -23, -12, -45, -1 })]
        public void RemoveItemFirstValue(int[] array, int value, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.RemoveItemFirstValue(value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2, 1)]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, 5, 3)]
        [TestCase(new int[] { 1, 43, 35, 99, 23 }, 99, 3)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, -12, 1)]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, 0, 4)]
        public void GetIndexByValue(int[] array, int value, int expArr)
        {
            int expected = expArr;
            DoubleLL actual = new DoubleLL(array);

            int result = actual.GetIndexByValue(value);

            Assert.AreEqual(expected, result);
        }



        [TestCase(new int[] { 1, 2, 2 }, 2, new int[] { 1 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 6, new int[] { 2, 1, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 99, new int[] { 1, 35, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, -12, new int[] { 23, -84, 34 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 0, new int[] { -12, -45, -1 })]
        public void RemoveItemByValueAll(int[] array, int value, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.RemoveItemByValueAll(value);

            Assert.AreEqual(expected, actual);
        }



        //[TestCase(new int[] { 1, 2, 3 }, 2, 3)]
        //[TestCase(new int[] { 2, 6, 1, 6, 0 }, 4, 0)]
        //[TestCase(new int[] { 1, 99, 35, 99, 23 }, 3, 99)]
        //[TestCase(new int[] { 23, -12, -84, 34, -12 }, 3, 34)]
        //[TestCase(new int[] { 0, -12, -45, -1, 0 }, 0, 0)]
        //public void AccessByIndex(int[] array, int index, int exp)
        //{
        //    int expected = exp;
        //    DoubleLL actual = new DoubleLL(array);

        //    int result = actual.AccessByIndex(index);

        //    Assert.AreEqual(expected, result);
        //}


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, -2, 1 }, new int[] { 1, 2, 3, 3, -2, 1 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, new int[] { 5, 2, 1, 0 }, new int[] { 2, 6, 1, 6, 0, 5, 2, 1, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, new int[] { 43, 22, 12 }, new int[] { 1, 99, 35, 99, 23, 43, 22, 12 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, new int[] { 32, 1, 2, 3 }, new int[] { 23, -12, -84, 34, -12, 32, 1, 2, 3 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, new int[] { 3, -4, 21 }, new int[] { 0, -12, -45, -1, 0, 3, -4, 21 })]
        public void Add(int[] array, int[] AddArr, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.Add(AddArr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, -2, 1 }, new int[] { 3, -2, 1, 1, 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, new int[] { 5, 2, 1, 0 }, new int[] { 5, 2, 1, 0, 2, 6, 1, 6, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, new int[] { 43, 22, 12 }, new int[] { 43, 22, 12, 1, 99, 35, 99, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, new int[] { 32, 1, 2, 3 }, new int[] { 32, 1, 2, 3, 23, -12, -84, 34, -12 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, new int[] { 3, -4, 21 }, new int[] { 3, -4, 21, 0, -12, -45, -1, 0 })]
        public void AddByFirst(int[] array, int[] AddArr, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.AddByFirst(AddArr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, -2, 1 }, 1, new int[] { 1, 3, -2, 1, 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, new int[] { 5, 2, 1, 0 }, 3, new int[] { 2, 6, 1, 5, 2, 1, 0, 6, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, new int[] { 43, 22, 12 }, 4, new int[] { 1, 99, 35, 99, 43, 22, 12, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, new int[] { 32, 1, 2, 3 }, 1, new int[] { 23, 32, 1, 2, 3, -12, -84, 34, -12 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, new int[] { 3, -4, 21 }, 4, new int[] { 0, -12, -45, -1, 3, -4, 21, 0 })]
        public void AddByIndex(int[] array, int[] AddArr, int index, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.AddByIndex(index, AddArr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 3, new int[] { 2, 6 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 2, new int[] { 1, 99, 35 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, 5, new int[] { })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 4, new int[] { 0 })]
        public void Remove(int[] array, int quantity, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.Remove(quantity);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 3, new int[] { 6, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 2, new int[] { 35, 99, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, 5, new int[] { })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 4, new int[] { 0 })]
        public void RemoveFirst(int[] array, int quantity, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.RemoveFirst(quantity);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 3, 2, new int[] { 2, 6, 1 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 2, 3, new int[] { 1, 99 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, 4, 1, new int[] { 23, -12, -84, 34 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 0, 5, new int[] { })]
        public void RemoveByIndex(int[] array, int index, int quantity, int[] expArray)
        {
            DoubleLL expected = new DoubleLL(expArray);
            DoubleLL actual = new DoubleLL(array);

            actual.RemoveByIndex(index, quantity);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 1, 2, 3 }, 5, 1)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1, 2)]
        public void Add(int[] array, int index, int value)
        {
            try
            {
                DoubleLL actual = new DoubleLL(array);
                actual.AddByIndex(index, value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase(new int[] { 1, 2, 3 }, 5, 1)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1, 2)]
        public void AddByIndexNegative(int[] array, int index, int value)
        {
            try
            {
                DoubleLL actual = new DoubleLL(array);
                actual.AddByIndex(index, value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }



        [TestCase(new int[] { 1, 2, 3 }, 5)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1)]
        public void RemoveByIndexNegative(int[] array, int index)
        {
            try
            {
                DoubleLL actual = new DoubleLL(array);
                actual.RemoveByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }



        [TestCase(new int[] { 1, 2, 3 }, 5, 2)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1, 8)]
        public void ChangeIndexNegative(int[] array, int index, int value)
        {
            try
            {
                DoubleLL actual = new DoubleLL(array);
                actual.ChangeIndex(index, value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}