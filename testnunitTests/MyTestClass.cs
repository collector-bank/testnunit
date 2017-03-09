using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testnunit;

namespace testnunitTests
{
    public class MyTestClass
    {
        [Test]
        public void TestAdd()
        {
            var obj = new MyClass();
            int a = 1;
            int b = 2;
            int result = obj.Add(a, b);
            Assert.AreEqual(result, 3);
        }
    }
}
