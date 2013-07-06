using System;
using NUnit.Framework;

namespace Fooidity.Tests
{
    [TestFixture]
    public class when_turning_a_feature_on_during_a_time_span
    {
        [Test]
        public void then_the_feature_is_disabled_prior_to_the_start()
        {
            var foo = new EnabledDuring<TestFeature>(DateTimeOffset.MaxValue.AddSeconds(-1), 
                                                     DateTimeOffset.MaxValue);

            Assert.IsFalse(foo.Enabled);
        }

        [Test]
        public void then_the_feature_is_disabled_after_the_end()
        {
            var foo = new EnabledDuring<TestFeature>(DateTimeOffset.MinValue,
                                                     DateTimeOffset.MinValue.AddSeconds(1));

            Assert.IsFalse(foo.Enabled);
        }

        [Test]
        public void then_the_feature_is_enabled_during_the_time_span()
        {
            var foo = new EnabledDuring<TestFeature>(DateTimeOffset.MinValue,
                                                     DateTimeOffset.Now.AddMinutes(1));

            Assert.IsTrue(foo.Enabled);
        }
    }
}