using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchAlgorithms;

namespace SearchEngineUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleSearchEngine engine = new SimpleSearchEngine();
            int[] array = new int[]{ 1, 2, 3, 4 };
            bool result = engine.Search(array, 5);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            SimpleSearchEngine engine = new SimpleSearchEngine();
            int[] array = new int[] { 1, 2, 3, 4 };
            bool result = engine.Search(array, 4);
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void TestBinarySearch1()
        {
            BinarySearchEngine engine = new BinarySearchEngine();
            int[] array = new int[] { 1, 2, 3, 4 };
            bool result = engine.Search(array, 5);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestBinarySearch2()
        {
            BinarySearchEngine engine = new BinarySearchEngine();
            int[] array = new int[] { 1, 2, 3, 4 };
            bool result = engine.Search(array, 4);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestBinarySearch3()
        {
            BinarySearchEngine engine = new BinarySearchEngine();
            int[] array = new int[] { 1, 2, 3, 4 };
            bool result = engine.Search(array, 1);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestBinarySearch4()
        {
            BinarySearchEngine engine = new BinarySearchEngine();
            int[] array = new int[] { 1, 2, 3, 4 };
            bool result = engine.Search(array, -1);
            Assert.AreEqual(false, result);
        }
    }
}
