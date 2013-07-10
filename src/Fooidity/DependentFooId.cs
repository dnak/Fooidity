namespace Fooidity
{
    public interface DependentFooId : FooId
    {
    }

    public interface When<TFoo> : DependentFooId where TFoo : FooId
    {
        void When(FooId<TFoo> fooId);
    }

    public interface Unless<TFoo> : DependentFooId where TFoo : FooId
    {
        void Unless(FooId<TFoo> fooId);
    }
}