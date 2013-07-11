




namespace Fooidity
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	
    public class CompositeBuilder<T,T1>
        where T : FooId
		where T1 : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1, T2> When<T2>() where T2 : FooId
        {
			var composite = new CompositeFooId<T,T1, T2>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T2>(() => _resolver.Resolve<T2>().Enabled));
            return new CompositeBuilder<T,T1, T2>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1, T2> Unless<T2>() where T2 : FooId
        {
			var composite = new CompositeFooId<T,T1, T2>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T2>(() => _resolver.Resolve<T2>().Enabled));
            return new CompositeBuilder<T,T1, T2>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2>
        where T : FooId
		where T1 : FooId
		where T2 : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2, T3> When<T3>() where T3 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2, T3>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T3>(() => _resolver.Resolve<T3>().Enabled));
            return new CompositeBuilder<T,T1,T2, T3>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2, T3> Unless<T3>() where T3 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2, T3>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T3>(() => _resolver.Resolve<T3>().Enabled));
            return new CompositeBuilder<T,T1,T2, T3>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3>
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3, T4> When<T4>() where T4 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3, T4>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T4>(() => _resolver.Resolve<T4>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3, T4>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3, T4> Unless<T4>() where T4 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3, T4>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T4>(() => _resolver.Resolve<T4>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3, T4>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4>
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4, T5> When<T5>() where T5 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4, T5>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T5>(() => _resolver.Resolve<T5>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4, T5>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4, T5> Unless<T5>() where T5 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4, T5>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T5>(() => _resolver.Resolve<T5>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4, T5>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5>
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5, T6> When<T6>() where T6 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5, T6>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T6>(() => _resolver.Resolve<T6>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5, T6>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5, T6> Unless<T6>() where T6 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5, T6>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T6>(() => _resolver.Resolve<T6>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5, T6>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6>
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6, T7> When<T7>() where T7 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6, T7>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T7>(() => _resolver.Resolve<T7>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6, T7>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6, T7> Unless<T7>() where T7 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6, T7>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T7>(() => _resolver.Resolve<T7>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6, T7>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7>
        where T : FooId
		where T1 : FooId
		where T2 : FooId
		where T3 : FooId
		where T4 : FooId
		where T5 : FooId
		where T6 : FooId
		where T7 : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7, T8> When<T8>() where T8 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7, T8>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T8>(() => _resolver.Resolve<T8>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7, T8>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7, T8> Unless<T8>() where T8 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7, T8>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T8>(() => _resolver.Resolve<T8>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7, T8>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8, T9> When<T9>() where T9 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8, T9>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T9>(() => _resolver.Resolve<T9>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8, T9>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8, T9> Unless<T9>() where T9 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8, T9>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T9>(() => _resolver.Resolve<T9>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8, T9>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10> When<T10>() where T10 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T10>(() => _resolver.Resolve<T10>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10> Unless<T10>() where T10 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T10>(() => _resolver.Resolve<T10>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11> When<T11>() where T11 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T11>(() => _resolver.Resolve<T11>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11> Unless<T11>() where T11 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T11>(() => _resolver.Resolve<T11>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12> When<T12>() where T12 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T12>(() => _resolver.Resolve<T12>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12> Unless<T12>() where T12 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T12>(() => _resolver.Resolve<T12>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13> When<T13>() where T13 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T13>(() => _resolver.Resolve<T13>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13> Unless<T13>() where T13 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T13>(() => _resolver.Resolve<T13>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14> When<T14>() where T14 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T14>(() => _resolver.Resolve<T14>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14> Unless<T14>() where T14 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T14>(() => _resolver.Resolve<T14>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15> When<T15>() where T15 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T15>(() => _resolver.Resolve<T15>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15> Unless<T15>() where T15 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T15>(() => _resolver.Resolve<T15>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16> When<T16>() where T16 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16>(() => _fooId.Enabled);
            composite.When(new DeferredEvaluation<T16>(() => _resolver.Resolve<T16>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16> Unless<T16>() where T16 : FooId
        {
			var composite = new CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16>(() => _fooId.Enabled);
            composite.Unless(new DeferredEvaluation<T16>(() => _resolver.Resolve<T16>().Enabled));
            return new CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16>(_resolver, _registration, composite);
        }
		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }
	
    public class CompositeBuilder<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>
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
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;
        private readonly CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> _fooId;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration, CompositeFooId<T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> fooId)
        {
            _resolver = resolver;
			_registration = registration;
            _fooId = fooId;
        }

		
        public FooId<T> Build()
        {
			_registration(_fooId);
            return _fooId;
        }
    }

    public class CompositeBuilder<T>
        where T : FooId
    {
        private readonly Resolver _resolver;
		private readonly Action<FooId<T>> _registration;

        public CompositeBuilder(Resolver resolver, Action<FooId<T>> registration)
        {
            _resolver = resolver;
			_registration = registration;
        }

        public CompositeBuilder<T, T1> When<T1>() where T1 : FooId
        {
            var composite = new CompositeFooId<T, T1>();
            composite.When(new DeferredEvaluation<T1>(() => _resolver.Resolve<T1>().Enabled));
            return new CompositeBuilder<T, T1>(_resolver, _registration, composite);
        }
		
        public CompositeBuilder<T, T1> Unless<T1>() where T1 : FooId
        {
            var composite = new CompositeFooId<T, T1>();
            composite.Unless(new DeferredEvaluation<T1>(() => _resolver.Resolve<T1>().Enabled));
            return new CompositeBuilder<T, T1>(_resolver, _registration, composite);
        }
    }   	
}
