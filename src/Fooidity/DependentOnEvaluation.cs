using System;

namespace Fooidity
{
    public class DependentOnEvaluation<TFoo> : FooId<TFoo> where TFoo : FooId
    {
        private readonly Func<bool> _evaluation;

        public DependentOnEvaluation(Func<bool> evaluation)
        {
            _evaluation = evaluation;
        }

        public bool Enabled
        {
            get { return _evaluation(); }
        }
    }
}