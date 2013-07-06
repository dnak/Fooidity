using System;

namespace Fooidity
{
    public class EnabledDuring<TFoo> :
        FooId<TFoo>
        where TFoo : FooId
    {
        private readonly DateTimeOffset _startTime;
        private readonly DateTimeOffset _endTime;

        public EnabledDuring(DateTimeOffset startTime,
                             DateTimeOffset endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
        }

        public bool Enabled
        {
            get
            {
                var now = DateTimeOffset.Now;
                return now >= _startTime && now < _endTime;
            }
        }
    }
}