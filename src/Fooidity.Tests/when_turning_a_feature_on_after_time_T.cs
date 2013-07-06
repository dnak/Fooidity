using System;
using NUnit.Framework;

namespace Fooidity.Tests
{
    [TestFixture]
    public class when_turning_a_feature_on_after_time_T
    {
        [Test]
        public void then_the_feature_is_disabled_prior_to_T()
        {
            var foo = new EnabledAfter<TestFeature>(DateTimeOffset.MaxValue);

            Assert.IsFalse(foo.Enabled);
        }

        [Test]
        public void then_the_feature_is_enabled_after_T()
        {
            var foo = new EnabledAfter<TestFeature>(DateTimeOffset.MinValue);

            Assert.IsTrue(foo.Enabled);
        }
    }
}