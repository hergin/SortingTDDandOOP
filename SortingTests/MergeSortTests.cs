using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Tests
{
    [TestClass()]
    public class MergeSortTests
    {
        [TestMethod()]
        public void sortTestEven()
        {
            MergeSort mergeSort = new MergeSort();

            List<int> list = new List<int>() { 1, 5, 2, 4, 7, 3, 9, 8 };

            List<int> expectedResult = new List<int>() { 1, 2, 3, 4, 5, 7, 8, 9 };

            List<int> actualResult = mergeSort.sort(list);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod()]
        public void sortTest()
        {
            MergeSort mergeSort = new MergeSort();

            List<int> list = new List<int>() { 1,5,2,4,7 };

            List<int> expectedResult = new List<int>() { 1, 2, 4, 5, 7 };

            List<int> actualResult = mergeSort.sort(list);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod()]
        public void sortTest2()
        {
            MergeSort mergeSort = new MergeSort();

            List<int> list = new List<int>() { 1 };

            List<int> expectedResult = new List<int>() { 1 };

            List<int> actualResult = mergeSort.sort(list);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }


    }
}