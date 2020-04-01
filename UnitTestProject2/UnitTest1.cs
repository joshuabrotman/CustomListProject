using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

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


        public void Remove_CheckCountIsStillTheSame_RemoveNonExistentItem()
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
            testlist.Remove(66);
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
