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

    [TestFixture]
    public class when_evaluating_a_dependent_fooId
    {
        [Test]
        public void then_()
        {
            DependentFooIdBuilder<Dependent> builder = new DependentFooIdBuilder<Dependent>();
            
            Assert.IsTrue(builder.BuildFooId().Enabled);
        }
    }

    internal interface Dependent : When<Foo1>
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