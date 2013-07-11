




namespace Fooidity
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	
    public class CompositeFooId<T,T1> : FooId<T> 
        where T : FooId
		where T1 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
		where T10 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> When(FooId<T10> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> Unless(FooId<T10> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
		where T10 : FooId
		where T11 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T10> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T10> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> When(FooId<T11> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> Unless(FooId<T11> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
		where T10 : FooId
		where T11 : FooId
		where T12 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T10> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T10> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T11> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T11> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> When(FooId<T12> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> Unless(FooId<T12> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
		where T10 : FooId
		where T11 : FooId
		where T12 : FooId
		where T13 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T10> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T10> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T11> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T11> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T12> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T12> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> When(FooId<T13> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> Unless(FooId<T13> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
		where T10 : FooId
		where T11 : FooId
		where T12 : FooId
		where T13 : FooId
		where T14 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T10> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T10> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T11> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T11> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T12> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T12> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T13> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T13> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> When(FooId<T14> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> Unless(FooId<T14> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
		where T10 : FooId
		where T11 : FooId
		where T12 : FooId
		where T13 : FooId
		where T14 : FooId
		where T15 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T10> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T10> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T11> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T11> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T12> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T12> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T13> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T13> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T14> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T14> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> When(FooId<T15> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> Unless(FooId<T15> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
	
    public class CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> : FooId<T> 
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
		where T8 : FooId
		where T9 : FooId
		where T10 : FooId
		where T11 : FooId
		where T12 : FooId
		where T13 : FooId
		where T14 : FooId
		where T15 : FooId
		where T16 : FooId
    {
        private readonly List<Func<bool>> _evaluations = new List<Func<bool>>(); 
		
        public CompositeFooId()
        {
            
        }

        public CompositeFooId(Func<bool> _initialEvaluation)
        {
            _evaluations.Add(_initialEvaluation);
        }

        public bool Enabled 
		{ 
			get
			{
				return _evaluations.All(evaluation => evaluation());
			}
		}
		
		
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T1> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T1> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T2> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T2> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T3> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T3> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T4> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T4> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T5> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T5> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T6> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T6> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T7> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T7> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T8> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T8> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T9> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T9> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T10> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T10> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T11> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T11> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T12> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T12> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T13> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T13> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T14> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T14> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T15> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T15> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }	
        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> When(FooId<T16> fooId)
        {
            _evaluations.Add(() => fooId.Enabled);
            return this;
        }

        public CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> Unless(FooId<T16> fooId)
        {
            _evaluations.Add(() => !fooId.Enabled);
            return this;
        }   
    }
   	
}
