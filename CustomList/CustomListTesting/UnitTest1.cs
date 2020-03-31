using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_CheckCount_AddPositiveInteger()
        {
            //arrange
            MyList<int> testingList = new MyList<int>();
            int value1 = 5;
            int expected = 1;
            int actual;
            //act
            testingList.Add(value1);
            actual = testingList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CheckZeroIndex_AddPositiveInteger()
        {
            //arrange
            MyList<int> testingList = new MyList<int>();
            int value1 = 5;
            int expected = 5;
            int actual;
            //act
            testingList.Add(value1);
            actual = testingList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CheckZeroIndex_AddPositiveInteger()
        {
            //arrange
            MyList<int> testingList = new MyList<int>();
            int value1 = 5;
            int expected = 5;
            int actual;
            //act
            testingList.Add(value1);
            testingList.Add(value1);
            testingList.Add(value1);
            testingList.Add(value1);
            testingList.Add(value1);
            actual = testingList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
