﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using BasicLibrary.IO;
using SimpleLibrary.BasicLibraryTests.TestClasses;
using System.IO;

namespace SimpleLibrary.BasicLibraryTests
{
    [TestFixture]
    public class StringFragmenterTests
    {
        [Test]
        public void SimpleTest1()
        {
            var s = StringFragmenter.Parse<TestStringClass1>("0123456789009876543210");

            Assert.AreEqual(1234, s.TestInt);
            Assert.AreEqual(5678.9, s.TestDecimal);

            Assert.AreEqual(98765, s.TestInt2);
            Assert.AreEqual(43210, s.TestDecimal2);
        }

        [Test]
        public void SimpleTest2()
        {
            var s = StringFragmenter.Parse<TestStringClass2>("012345678,9098765432.1");

            Assert.AreEqual(1234, s.TestInt);
            Assert.AreEqual(5678.9, s.TestDecimal);

            Assert.AreEqual(98765, s.TestInt2);
            Assert.AreEqual(432.1, s.TestDecimal2);
        }

        [Test]
        public void SimpleTestFormatException3()
        {
            var s = StringFragmenter.Parse<TestStringClass2>("012345678.9098765432.1");

            Assert.AreEqual(1234, s.TestInt);
            Assert.AreEqual(56789, s.TestDecimal);

            Assert.AreEqual(98765, s.TestInt2);
            Assert.AreEqual(432.1, s.TestDecimal2);
        }

        [Test]
        public void SimpleTestFormatException4()
        {
            var s = StringFragmenter.Parse<TestStringClass2>("012345678,9098765432,1");

            Assert.AreEqual(1234, s.TestInt);
            Assert.AreEqual(5678.9, s.TestDecimal);

            Assert.AreEqual(98765, s.TestInt2);
            Assert.AreEqual(4321, s.TestDecimal2);
        }

        [Test]
        public void ExtremeCaseAllInOne()
        {
            var s = StringFragmenter.Parse<TestStringClass3>("123,5.9999");

            Assert.AreEqual(123m, s.TestInt);
            Assert.AreEqual(123.5m, s.TestDecimal);
            Assert.AreEqual(123m, s.TestInt2);
            Assert.AreEqual(1235.9999, s.TestDecimal2);
        }

        [Test]
        [ExpectedException(typeof(FormatException))]
        public void FormatExceptionCase()
        {
            var s = StringFragmenter.Parse<TestStringClass4>("123,5");
        }

        [Test]
        public void StreamTest()
        {
            string st = "0123456789009876543210\n0123456789009876543210\n0123456789009876543210";
            MemoryStream mem = new MemoryStream(Encoding.UTF8.GetBytes(st));

            IList<TestStringClass1> list = StringFragmenter.Parse<TestStringClass1>(mem);

            Assert.AreEqual(3, list.Count);
            foreach (var s in list)
            {
                Assert.AreEqual(1234, s.TestInt);
                Assert.AreEqual(5678.9, s.TestDecimal);

                Assert.AreEqual(98765, s.TestInt2);
                Assert.AreEqual(43210, s.TestDecimal2);
            }
        }


        [Test]
        public void ArrayTest()
        {
            string st = "0123456789009876543210\n0123456789009876543210\n0123456789009876543210";
            string[] mem = st.Split('\n');

            IList<TestStringClass1> list = StringFragmenter.Parse<TestStringClass1>(mem);

            Assert.AreEqual(3, list.Count);
            foreach (var s in list)
            {
                Assert.AreEqual(1234, s.TestInt);
                Assert.AreEqual(5678.9, s.TestDecimal);

                Assert.AreEqual(98765, s.TestInt2);
                Assert.AreEqual(43210, s.TestDecimal2);
            }
        }
    }
}
