using System;
using System.Collections.Generic;
using ModestTree.Zenject;
using NUnit.Framework;
using ModestTree.Tests;
using TestAssert=NUnit.Framework.Assert;
using System.Linq;

namespace ModestTree.Tests.Zenject
{
    [TestFixture]
    public class TestTestUtil
    {
        [Test]
        public void TestTrue()
        {
            TestAssert.IsTrue(TestListComparer.ContainSameElements(
                new List<int> {1},
                new List<int> {1}));

            TestAssert.IsTrue(TestListComparer.ContainSameElements(
                new List<int> {1, 2},
                new List<int> {2, 1}));

            TestAssert.IsTrue(TestListComparer.ContainSameElements(
                new List<int> {1, 2, 3},
                new List<int> {3, 2, 1}));

            TestAssert.IsTrue(TestListComparer.ContainSameElements(
                new List<int> {},
                new List<int> {}));
        }

        [Test]
        public void TestFalse()
        {
            TestAssert.IsFalse(TestListComparer.ContainSameElements(
                new List<int> {1, 2, 3},
                new List<int> {3, 2, 3}));

            TestAssert.IsFalse(TestListComparer.ContainSameElements(
                new List<int> {1, 2},
                new List<int> {1, 2, 3}));
        }
    }
}



