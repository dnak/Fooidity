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
            Evaluation<T1> evaluation = new Evaluation<T1>(new EnabledFooId<T1>());
            string result = evaluation.Capture().Results;
            Console.WriteLine(result);
            string expected = "{\"Fooidity.Tests.T1\":{\"Enabled\":\"True\"}}";
            Assert.AreEqual(expected, result);
        }

    }

    internal class T1 : FooId
    {
    }

    internal class T2 : FooId
    {
    }

    internal class T3 : FooId
    {
    }
}