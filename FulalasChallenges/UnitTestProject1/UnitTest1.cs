using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using FulalasChallenges;

// Contar quantos elementos há numa lista encadeada dado que o índice 0 tem como valor o índice para o próximo elemento,
// e no caso desse valor ser -1 significa que a lista acabou. Ex.: no array [1, 4, -1, 3, 2, 8] o total de elementos é 3..

namespace FullalasChallenges1Test
{
    [TestClass]
    public class UnitTest1
    {
        Problem1Strategy strategy = new Problem1WorkingTry2();

        [TestMethod]
        public void TestMethod1()
        {
            int[] listValues1 = { 1, 40, 10, 20, -1 }; // 5
            var linkedList = new LinkedList<int>(listValues1);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] listValues2 = { 1, -1 }; // 2
            var linkedList = new LinkedList<int>(listValues2);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] listValues3 = { 400, 2, -1 }; // 2
            var linkedList = new LinkedList<int>(listValues3);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] listValues4 = { 400, 2, -1, 500 }; // 2
            var linkedList = new LinkedList<int>(listValues4);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] listValues5 = { 400, 2, 300, -4, -1, 500 }; // 4
            var linkedList = new LinkedList<int>(listValues5);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(4, count);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] listValues6 = { 10, 400, 3, 300, -4, -1, 500, 3 }; // 4
            var linkedList = new LinkedList<int>(listValues6);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(4, count);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] listValuestricky1 = { 10, 400, 3, 4, -4, -1, 500, 3 }; // 4
            var linkedList = new LinkedList<int>(listValuestricky1);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(4, count);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] listValuestricky2 = { 10, 400, 3, 90, -4, 6, 500, 3, -1 }; // 7 
            var linkedList = new LinkedList<int>(listValuestricky2);
            var count = strategy.Count(linkedList);
            Assert.AreEqual(7, count);
        }
    }
}
