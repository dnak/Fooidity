using System;
using NUnit.Framework;

namespace Fooidity.Tests
{
    [TestFixture]
    public class when_capturing_feature_evaluation
    {
        [Test]
        public void then_the_evaluation_is_retained()
        {
            var fooid = FooIds.Enabled<Foo1>();
            string result = fooid.Capture().Serialize().Results;   // ugly ass - fix
            Console.WriteLine(result);
            string expected = "{\"Fooidity.Tests.Foo1\":{\"Enabled\":\"True\"}}";
            Assert.AreEqual(expected, result);
        }
    }

    internal interface Dependent : FooId
    {
    }

    internal class Foo1 : FooId
    {
    }

    internal class Foo2 : FooId
    {
    }

    internal class Foo3 : FooId
    {
    }
}