using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OperatorPlusOverload_CheckConcatenate_AddTwoLists()
        {
            //arrange
            ArrayList<int> list1 = new ArrayList<int>();
            ArrayList<int> list2 = new ArrayList<int>();
            ArrayList<int> list3 = new ArrayList<int>();
            list1.Add(1);
            list1.Add(2);
            list2.Add(3);
            list2.Add(4);
            ArrayList<int> expected = new ArrayList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            //act
            list3 = list1 + list2;
            //assert
            Assert.AreEqual(expected, list3);
        }

        [TestMethod]

        public void ToString_Check5Digits_AddPositiveIntegers()
        {
            //arrange
            string expected = "12345";
            string actual = "";
            //act
            ArrayList<int> testlist = new ArrayList<int>();
            testlist.Add(1);
            testlist.Add(2);
            testlist.Add(3);
            testlist.Add(4);
            testlist.Add(5);
            actual = testlist.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CheckCountIsLower_RemovePositiveInteger()
        {
            //arrange
            
            int expected = 2;
            int actual;
            //act
            ArrayList<int> testlist = new ArrayList<int>();
            testlist.Add(99);
            testlist.Add(43);
            testlist.Add(55);
            testlist.Remove(55);
            actual = testlist.Count;
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_CheckIndex1IsChanged_RemoveIndex1()
        {
            //arrange
            int expected = 12;
            int actual;
            //act
            ArrayList<int> testlist = new ArrayList<int>();
            testlist.Add(99);
            testlist.Add(43);
            testlist.Add(12);
            testlist.Remove(43);
            actual = testlist[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Check1stIndexRemains_RemoveIndex1()
        {
            //arrange
            int expected = 99;
            int actual;
            //act
            ArrayList<int> testlist = new ArrayList<int>();
            testlist.Add(99);
            testlist.Add(43);
            testlist.Add(12);
            testlist.Remove(43);
            actual = testlist[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CheckTopElementsShiftDown_RemoveIndex1()
        {
            //arrange
            int expected = 22;
            int actual;
            //act
            ArrayList<int> testlist = new ArrayList<int>();
            testlist.Add(99);
            testlist.Add(43);
            testlist.Add(12);
            testlist.Add(22);
            testlist.Remove(43);
            actual = testlist[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CheckCountIsStillTheSame_RemoveNonExistentItem()
        {
            //arrange
            int expected = 4;
            int actual;
            //act
            ArrayList<int> testlist = new ArrayList<int>();
            testlist.Add(99);
            testlist.Add(43);
            testlist.Add(12);
            testlist.Add(22);
            testlist.Remove(66);
            actual = testlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_CheckOnlyOneRemoved_RemoveItemTwice()
        {
            //arrange
            int expected = 3;
            int actual;
            //act
            ArrayList<int> testlist = new ArrayList<int>();
            testlist.Add(99);
            testlist.Add(43);
            testlist.Add(12);
            testlist.Add(22);
            testlist.Remove(22);
            testlist.Remove(22);
            actual = testlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_CheckCount_AddPositiveInteger()
        {

            //arrange
            ArrayList<int> testList1 = new ArrayList<int>();
            int value1 = 5;
            int expected = 1;
            int actual;
            //act
            testList1.Add(value1);
            actual = testList1.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckIndex_ReturnsValueOfIndex()
        {

            //arrange
            ArrayList<int> testList1 = new ArrayList<int>();
            int value1 = 5;
            int expected = 5;
            int actual;
            //act
            testList1.Add(value1);
            actual = testList1[0];
            //assert
            Assert.AreEqual(expected, actual);
        }


        //add an element, make sure it exists
        [TestMethod]
        public void Add_CheckElement_ReturnsElementsJustAdded()
        {

            //arrange
            int actual;
            ArrayList<int> testList1 = new ArrayList<int>();

            //act
            testList1.Add(5);
            testList1.Add(54);
            actual = testList1[1];


            //assert
            Assert.AreEqual(54, actual);

        }

        //add one int element, make sure original is still present
        [TestMethod]
        public void Add_CheckElement_IsOriginalStillThere()
        {
            //arrange
            int actual;
            ArrayList<int> testList1 = new ArrayList<int>();

            //act
            testList1.Add(5);
            testList1.Add(43);
            actual = testList1[0];


            //assert
            Assert.AreEqual(5, actual);
        }
        //test that capacity increases accordingly

        [TestMethod]
        public void Add_CheckCapacity_DoesCapacityExpand()
        {
            //arrange
            ArrayList<int> testList1 = new ArrayList<int>();

            //act
            testList1.Add(32);
            testList1.Add(43);
            testList1.Add(89);
            testList1.Add(11);
            testList1.Add(19);
            //assert

            Assert.AreEqual(8, testList1.ArrayCapacity);
        }


        
    }
}
