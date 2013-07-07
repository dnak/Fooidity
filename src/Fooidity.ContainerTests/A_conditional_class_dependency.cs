namespace Fooidity.ContainerTests
{
    using Autofac;
    using NUnit.Framework;
    using Subjects;


    [TestFixture]
    public class A_conditional_class_dependency
    {
        [Test]
        public void Should_use_the_new_methods()
        {
            var builder = new ContainerBuilder();

            builder.Enabled<UseNewMethod>();

            builder.RegisterType<ConditionalClass>();

            var container = builder.Build();

            WillUseNewImplementation(container);
        }

        [Test]
        public void Should_use_the_old_methods()
        {
            var builder = new ContainerBuilder();

            builder.Disabled<UseNewMethod>();

            builder.RegisterType<ConditionalClass>();

            var container = builder.Build();

            WillUseOldImplementation(container);
        }

        [Test]
        public void Should_use_the_old_methods_by_default()
        {
            var builder = new ContainerBuilder();

            builder.FooIdsDisabledByDefault();

            builder.RegisterType<ConditionalClass>();

            var container = builder.Build();

            WillUseOldImplementation(container);
        }

        [Test]
        public void Should_be_able_to_enable_a_fooid_after_creation()
        {
            var builder = new ContainerBuilder();

            builder.Disabled<UseNewMethod>();

            builder.RegisterType<ConditionalClass>();

            var container = builder.Build();

            WillUseOldImplementation(container);

            container.Enable<UseNewMethod>();

            WillUseNewImplementation(container);

        }

        [Test]
        public void Should_retain_fooid_state_for_lifetime_of_scope()
        {
            var builder = new ContainerBuilder();
            builder.Enabled<UseNewMethod>();
            builder.RegisterType<ConditionalClass>().InstancePerMatchingLifetimeScope("session");

            var container = builder.Build();
            using (var initialScope = container.BeginLifetimeScope("session"))
            {
                WillUseNewImplementation(initialScope);

                container.Disable<UseNewMethod>();

                WillUseNewImplementation(initialScope);
            }
        }

        [Test]
        public void Should_reevaluate_fooid_state_for_new_lifetime_scope()
        {
            var builder = new ContainerBuilder();
            builder.Enabled<UseNewMethod>();
            builder.RegisterType<ConditionalClass>().InstancePerMatchingLifetimeScope("session");

            var container = builder.Build();
            using (var initialScope = container.BeginLifetimeScope("session"))
            {
                WillUseNewImplementation(initialScope);

                container.Disable<UseNewMethod>();
                using (var subsequentScope = container.BeginLifetimeScope("session"))
                {
                    WillUseOldImplementation(subsequentScope);
                }
            }
        }

        private static void WillUseNewImplementation(ILifetimeScope scope)
        {
            var conditionalClass = scope.Resolve<ConditionalClass>();
            Assert.AreEqual("V2: 42, Test", conditionalClass.FunctionCall(42, "Test"));
        }

        private static void WillUseOldImplementation(ILifetimeScope scope)
        {
            var conditionalClass = scope.Resolve<ConditionalClass>();

            Assert.AreEqual("Old: 42, Test", conditionalClass.FunctionCall(42, "Test"));
        }
    }
}
