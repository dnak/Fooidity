using System;
using Autofac;
using Fooidity.AutofacIntegration;
using NUnit.Framework;

namespace Fooidity.ContainerTests
{
    [TestFixture]
    public class when_defining_dependent_features
    {
        [Test]
        public void then_an_injected_function_can_be_used()
        {
            Func<bool> expression = () => true;
            DependentOnEvaluation<A> fooId = new DependentOnEvaluation<A>(expression);

            Assert.IsTrue(fooId.Enabled);
        }

        [Test]
        public void then_enabled_dependencies_enable_the_fooid()
        {
            var builder = new ContainerBuilder();
            builder.Enabled<A>();
            builder.Enabled<B>();
            builder.RegisterFooId<ReallyCoolFeature>(); 
            builder.RegisterType<ReallyAwesomeImplementation>();
            var container = builder.Build();
            
            var implementation = container.Resolve<ReallyAwesomeImplementation>();

            Assert.AreEqual("new", implementation.Write());
        }

        [Test]
        public void then_a_disabled_dependency_disables_the_fooid()
        {
            var builder = new ContainerBuilder();
            builder.Enabled<A>();
            builder.Disabled<B>();
            builder.RegisterType<ReallyAwesomeImplementation>();
            builder.RegisterFooId<ReallyCoolFeature>();  

            var container = builder.Build();

            var implementation = container.Resolve<ReallyAwesomeImplementation>();

            Assert.AreEqual("old", implementation.Write());
        }

        [Test]
        public void then_a_disabled_dependency_enables_the_fooid_when_specified()
        {
            var builder = new ContainerBuilder();
            builder.Enabled<A>();
            builder.Disabled<B>();
            builder.RegisterType<OtherImplementation>();
            builder.RegisterFooId<ConflictsWithFooIdB>();

            var container = builder.Build();

            var implementation = container.Resolve<OtherImplementation>();

            Assert.AreEqual("new", implementation.Write());
        }

        [Test]
        public void then_an_enabled_dependency_disables_the_fooid_when_specified()
        {
            var builder = new ContainerBuilder();
            builder.Enabled<A>();
            builder.Enabled<B>();
            builder.RegisterType<OtherImplementation>();
            builder.RegisterFooId<ConflictsWithFooIdB>();

            var container = builder.Build();

            var implementation = container.Resolve<OtherImplementation>();

            Assert.AreEqual("old", implementation.Write());
        }

    }


    public class ReallyAwesomeImplementation
    {
        private readonly FooId<ReallyCoolFeature> _feature;

        public ReallyAwesomeImplementation(FooId<ReallyCoolFeature> feature)
        {
            _feature = feature;
        }

        public string Write()
        {
            return _feature.Iff(WriteNew, WriteOld);
        }

        private string WriteNew()
        {
            return "new";
        }

        private string WriteOld()
        {
            return "old";
        }
    }

    public class OtherImplementation
    {
        private readonly FooId<ConflictsWithFooIdB> _feature;

        public OtherImplementation(FooId<ConflictsWithFooIdB> feature)
        {
            _feature = feature;
        }

        public string Write()
        {
            return _feature.Iff(WriteNew, WriteOld);
        }

        private string WriteNew()
        {
            return "new";
        }

        private string WriteOld()
        {
            return "old";
        }
    }

    public interface ReallyCoolFeature : When<A>, When<B>
    {
    }

    public interface ConflictsWithFooIdB : When<A>, Unless<B>
    {
    }
    
    public class ABC : FooId { }
    public class A : FooId { }
    public class B : FooId { }
    public class C : FooId { }
}