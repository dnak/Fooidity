
namespace Fooidity
{
    public class Evaluation<T1>
			where T1 : FooId
    {
		private readonly FooId<T1> _arg1;

        public Evaluation(FooId<T1> arg1)
        {
			_arg1 = arg1;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2>
			where T1 : FooId
			where T2 : FooId
    {
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2)
        {
			_arg1 = arg1;
			_arg2 = arg2;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
    {
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
    {
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
    {
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
			where T6 : FooId
    {
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
			where T6 : FooId
			where T7 : FooId
    {
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
			where T6 : FooId
			where T7 : FooId
			where T8 : FooId
    {
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;
		private readonly FooId<T10> _arg10;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);
			result += serializer.Serialize(_arg10);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;
		private readonly FooId<T10> _arg10;
		private readonly FooId<T11> _arg11;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);
			result += serializer.Serialize(_arg10);
			result += serializer.Serialize(_arg11);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;
		private readonly FooId<T10> _arg10;
		private readonly FooId<T11> _arg11;
		private readonly FooId<T12> _arg12;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);
			result += serializer.Serialize(_arg10);
			result += serializer.Serialize(_arg11);
			result += serializer.Serialize(_arg12);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;
		private readonly FooId<T10> _arg10;
		private readonly FooId<T11> _arg11;
		private readonly FooId<T12> _arg12;
		private readonly FooId<T13> _arg13;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);
			result += serializer.Serialize(_arg10);
			result += serializer.Serialize(_arg11);
			result += serializer.Serialize(_arg12);
			result += serializer.Serialize(_arg13);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;
		private readonly FooId<T10> _arg10;
		private readonly FooId<T11> _arg11;
		private readonly FooId<T12> _arg12;
		private readonly FooId<T13> _arg13;
		private readonly FooId<T14> _arg14;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13, FooId<T14> arg14)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
			_arg14 = arg14;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);
			result += serializer.Serialize(_arg10);
			result += serializer.Serialize(_arg11);
			result += serializer.Serialize(_arg12);
			result += serializer.Serialize(_arg13);
			result += serializer.Serialize(_arg14);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;
		private readonly FooId<T10> _arg10;
		private readonly FooId<T11> _arg11;
		private readonly FooId<T12> _arg12;
		private readonly FooId<T13> _arg13;
		private readonly FooId<T14> _arg14;
		private readonly FooId<T15> _arg15;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13, FooId<T14> arg14, FooId<T15> arg15)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
			_arg14 = arg14;
			_arg15 = arg15;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);
			result += serializer.Serialize(_arg10);
			result += serializer.Serialize(_arg11);
			result += serializer.Serialize(_arg12);
			result += serializer.Serialize(_arg13);
			result += serializer.Serialize(_arg14);
			result += serializer.Serialize(_arg15);

			return new EvaluationResult(result);
		}
	}

    public class Evaluation<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>
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
		private readonly FooId<T1> _arg1;
		private readonly FooId<T2> _arg2;
		private readonly FooId<T3> _arg3;
		private readonly FooId<T4> _arg4;
		private readonly FooId<T5> _arg5;
		private readonly FooId<T6> _arg6;
		private readonly FooId<T7> _arg7;
		private readonly FooId<T8> _arg8;
		private readonly FooId<T9> _arg9;
		private readonly FooId<T10> _arg10;
		private readonly FooId<T11> _arg11;
		private readonly FooId<T12> _arg12;
		private readonly FooId<T13> _arg13;
		private readonly FooId<T14> _arg14;
		private readonly FooId<T15> _arg15;
		private readonly FooId<T16> _arg16;

        public Evaluation(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13, FooId<T14> arg14, FooId<T15> arg15, FooId<T16> arg16)
        {
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
			_arg14 = arg14;
			_arg15 = arg15;
			_arg16 = arg16;
        }    
        
		public EvaluationResult Capture()
		{
			var serializer = new EvaluationSerializer();
			var result = string.Empty;
			
			result += serializer.Serialize(_arg1);
			result += serializer.Serialize(_arg2);
			result += serializer.Serialize(_arg3);
			result += serializer.Serialize(_arg4);
			result += serializer.Serialize(_arg5);
			result += serializer.Serialize(_arg6);
			result += serializer.Serialize(_arg7);
			result += serializer.Serialize(_arg8);
			result += serializer.Serialize(_arg9);
			result += serializer.Serialize(_arg10);
			result += serializer.Serialize(_arg11);
			result += serializer.Serialize(_arg12);
			result += serializer.Serialize(_arg13);
			result += serializer.Serialize(_arg14);
			result += serializer.Serialize(_arg15);
			result += serializer.Serialize(_arg16);

			return new EvaluationResult(result);
		}
	}

   

	
}
