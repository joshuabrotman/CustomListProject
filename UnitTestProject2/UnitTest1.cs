using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
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
            actual = testList1[0];


            //assert
            Assert.AreEqual(5, actual);

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
        public void Add_CheckCapacity_DoesCapacityExpland()
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
