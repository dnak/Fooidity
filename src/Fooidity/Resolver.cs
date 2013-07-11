namespace Fooidity
{
    public interface Resolver
    {
        FooId<T> Resolve<T>() where T : FooId;
    }
}