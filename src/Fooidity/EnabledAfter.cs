using System;

namespace Fooidity
{
    public class EnabledAfter<TFoo> : 
        FooId<TFoo> 
        where TFoo : FooId
    {
        private readonly DateTimeOffset _enabledTime;

        public EnabledAfter(DateTimeOffset enabledTime)
        {
            _enabledTime = enabledTime;
        }

        public bool Enabled
        {
            get { return DateTimeOffset.Now >= _enabledTime; }
        }
    }
}