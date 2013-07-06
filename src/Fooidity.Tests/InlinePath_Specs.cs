namespace Fooidity.Tests
{
    using NUnit.Framework;


    [TestFixture]
    public class Using_a_fooid_inline
    {
        [Test]
        public void Should_allow_for_enabled_features()
        {
            FooId<TestFeature> fooId = FooIds.Enabled<TestFeature>();
            
            var result = fooId.Iff(() => 27, () => 42);
            Assert.AreEqual(27, result);

            var value = fooId.Iff((a, b) => a, (a, b) => b, 27, 42);
            Assert.AreEqual(27, value);
        }

        [Test]
        public void Should_allow_for_disabled_features()
        {
            FooId<TestFeature> fooId = FooIds.Disabled<TestFeature>();

            var result = fooId.Iff(() => 27, () => 42);
            Assert.AreEqual(42, result);

            var value = fooId.Iff((a, b) => a, (a, b) => b, 27, 42);
            Assert.AreEqual(42, value);
        }

        [Test]
        public void Should_allow_for_changing_feature_state()
        {
            FooId<TestFeature> fooId = FooIds.Disabled<TestFeature>();

            var result = fooId.Iff(() => 27, () => 42);
            Assert.AreEqual(42, result);

            fooId = FooIds.Enabled<TestFeature>();

            var value = fooId.Iff(() => 27, () => 42);
            Assert.AreEqual(27, value);
        }

        class TestFeature :
            FooId
        {
        }
    }
}