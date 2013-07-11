using System.Collections.Generic;

namespace Fooidity
{
    public interface IDependentFooIdBuilder<T> where T : FooId
    {
        FooId<T> BuildFooId();
    }

    public class DependentFooIdBuilder<T> : IDependentFooIdBuilder<T> where T : FooId
    {
        public DependentFooIdBuilder()
        {
            
        }

        public FooId<T> BuildFooId()
        {

            return new DeferredEvaluation<T>(() => true);
        }
    }
}