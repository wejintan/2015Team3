using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Tests
{
    [TestFixture]
    public class _06Test
    {
        [Test]
        public void Test()
        {
            Assert.That("Team 3", Is.EqualTo("Team 3"));
        }
    }
}
