using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Tests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void Test1()
        {
            Assert.That(1 + 1, Is.EqualTo(2));
            Assert.That(Article.five(), Is.EqualTo(5));
        }
        [Test]
        public void Test2()
        {
            Assert.That('A' + 1, Is.EqualTo('B'));
        }
    }
}
