using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Tests
{
    [TestFixture]
    class Search
    {
        [Test]
        public void Search1()
        {
            Assert.That("John", Is.EqualTo("John"));
        }
    }
}
