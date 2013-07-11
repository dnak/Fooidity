using System;

namespace Fooidity
{
    public class DeferredEvaluation<TFoo> : FooId<TFoo> where TFoo : FooId
    {
        private readonly Func<bool> _evaluation;

        public DeferredEvaluation(Func<bool> evaluation)
        {
            _evaluation = evaluation;
        }

        public bool Enabled
        {
            get { return _evaluation(); }
        }
    }
}