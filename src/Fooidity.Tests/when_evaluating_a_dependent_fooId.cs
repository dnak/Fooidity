using NUnit.Framework;

namespace Fooidity.Tests
{
    [TestFixture]
    public class when_evaluating_a_dependent_fooId
    {
        [Test]
        public void then_enabled_dependency_enables_fooid()
        {
            FooId<Dependent> fooId = new CompositeFooId<Dependent, Foo1>()
                .When(FooIds.Enabled<Foo1>());
            
            Assert.IsTrue(fooId.Enabled);
        }

        [Test]
        public void then_disabled_dependency_disables_fooid()
        {
            FooId<Dependent> fooId = new CompositeFooId<Dependent, Foo1>()
                .When(FooIds.Disabled<Foo1>());

            Assert.IsFalse(fooId.Enabled);
        }

        [Test]
        public void then_disabled_conflict_enables_fooid()
        {
            FooId<Dependent> fooId = new CompositeFooId<Dependent, Foo1>()
                .Unless(FooIds.Disabled<Foo1>());

            Assert.IsTrue(fooId.Enabled);
        }

        [Test]
        public void then_multiple_dependencies_can_be_enabled()
        {
            FooId<Dependent> fooId = new CompositeFooId<Dependent, Foo1, Foo2>()
                .When(FooIds.Enabled<Foo1>())
                .When(FooIds.Enabled<Foo2>());

            Assert.IsTrue(fooId.Enabled);
        }

        [Test]
        public void then_mix_dependencies_and_conflicts_will_enable()
        {
            FooId<Dependent> fooId = new CompositeFooId<Dependent, Foo1, Foo2>()
                .When(FooIds.Enabled<Foo1>())
                .Unless(FooIds.Disabled<Foo2>());

            Assert.IsTrue(fooId.Enabled);
        }

        [Test]
        public void then_mix_dependencies_and_conflicts_will_disable()
        {
            FooId<Dependent> fooId = new CompositeFooId<Dependent, Foo1, Foo2>()
                .When(FooIds.Enabled<Foo1>())
                .Unless(FooIds.Enabled<Foo2>());

            Assert.IsFalse(fooId.Enabled);
        }
    }
}