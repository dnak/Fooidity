




namespace Fooidity
{

    public class Snapshot<T1>
			where T1 : FooId
    {
        public Snapshot(FooId<T1> arg1)
        {
			FooId1 = arg1;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }

	}


    public class Snapshot<T1,T2>
			where T1 : FooId
			where T2 : FooId
    {
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2)
        {
			FooId1 = arg1;
			FooId2 = arg2;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }

	}


    public class Snapshot<T1,T2,T3>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
    {
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
    {
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
    {
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
			where T6 : FooId
    {
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
			where T6 : FooId
			where T7 : FooId
    {
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8>
			where T1 : FooId
			where T2 : FooId
			where T3 : FooId
			where T4 : FooId
			where T5 : FooId
			where T6 : FooId
			where T7 : FooId
			where T8 : FooId
    {
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
			FooId10 = arg10;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);
			result += serializer.Serialize(FooId10);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }
		public FooId<T10> FooId10 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
			FooId10 = arg10;
			FooId11 = arg11;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);
			result += serializer.Serialize(FooId10);
			result += serializer.Serialize(FooId11);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }
		public FooId<T10> FooId10 { get; private set; }
		public FooId<T11> FooId11 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
			FooId10 = arg10;
			FooId11 = arg11;
			FooId12 = arg12;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);
			result += serializer.Serialize(FooId10);
			result += serializer.Serialize(FooId11);
			result += serializer.Serialize(FooId12);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }
		public FooId<T10> FooId10 { get; private set; }
		public FooId<T11> FooId11 { get; private set; }
		public FooId<T12> FooId12 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
			FooId10 = arg10;
			FooId11 = arg11;
			FooId12 = arg12;
			FooId13 = arg13;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);
			result += serializer.Serialize(FooId10);
			result += serializer.Serialize(FooId11);
			result += serializer.Serialize(FooId12);
			result += serializer.Serialize(FooId13);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }
		public FooId<T10> FooId10 { get; private set; }
		public FooId<T11> FooId11 { get; private set; }
		public FooId<T12> FooId12 { get; private set; }
		public FooId<T13> FooId13 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13, FooId<T14> arg14)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
			FooId10 = arg10;
			FooId11 = arg11;
			FooId12 = arg12;
			FooId13 = arg13;
			FooId14 = arg14;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);
			result += serializer.Serialize(FooId10);
			result += serializer.Serialize(FooId11);
			result += serializer.Serialize(FooId12);
			result += serializer.Serialize(FooId13);
			result += serializer.Serialize(FooId14);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }
		public FooId<T10> FooId10 { get; private set; }
		public FooId<T11> FooId11 { get; private set; }
		public FooId<T12> FooId12 { get; private set; }
		public FooId<T13> FooId13 { get; private set; }
		public FooId<T14> FooId14 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13, FooId<T14> arg14, FooId<T15> arg15)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
			FooId10 = arg10;
			FooId11 = arg11;
			FooId12 = arg12;
			FooId13 = arg13;
			FooId14 = arg14;
			FooId15 = arg15;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);
			result += serializer.Serialize(FooId10);
			result += serializer.Serialize(FooId11);
			result += serializer.Serialize(FooId12);
			result += serializer.Serialize(FooId13);
			result += serializer.Serialize(FooId14);
			result += serializer.Serialize(FooId15);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }
		public FooId<T10> FooId10 { get; private set; }
		public FooId<T11> FooId11 { get; private set; }
		public FooId<T12> FooId12 { get; private set; }
		public FooId<T13> FooId13 { get; private set; }
		public FooId<T14> FooId14 { get; private set; }
		public FooId<T15> FooId15 { get; private set; }

	}


    public class Snapshot<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>
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
        public Snapshot(FooId<T1> arg1, FooId<T2> arg2, FooId<T3> arg3, FooId<T4> arg4, FooId<T5> arg5, FooId<T6> arg6, FooId<T7> arg7, FooId<T8> arg8, FooId<T9> arg9, FooId<T10> arg10, FooId<T11> arg11, FooId<T12> arg12, FooId<T13> arg13, FooId<T14> arg14, FooId<T15> arg15, FooId<T16> arg16)
        {
			FooId1 = arg1;
			FooId2 = arg2;
			FooId3 = arg3;
			FooId4 = arg4;
			FooId5 = arg5;
			FooId6 = arg6;
			FooId7 = arg7;
			FooId8 = arg8;
			FooId9 = arg9;
			FooId10 = arg10;
			FooId11 = arg11;
			FooId12 = arg12;
			FooId13 = arg13;
			FooId14 = arg14;
			FooId15 = arg15;
			FooId16 = arg16;
        }    

		public EvaluationResult Serialize()
		{
			var serializer = new EvaluationSerializer();	
			var result = string.Empty;

			result += serializer.Serialize(FooId1);
			result += serializer.Serialize(FooId2);
			result += serializer.Serialize(FooId3);
			result += serializer.Serialize(FooId4);
			result += serializer.Serialize(FooId5);
			result += serializer.Serialize(FooId6);
			result += serializer.Serialize(FooId7);
			result += serializer.Serialize(FooId8);
			result += serializer.Serialize(FooId9);
			result += serializer.Serialize(FooId10);
			result += serializer.Serialize(FooId11);
			result += serializer.Serialize(FooId12);
			result += serializer.Serialize(FooId13);
			result += serializer.Serialize(FooId14);
			result += serializer.Serialize(FooId15);
			result += serializer.Serialize(FooId16);

			return new EvaluationResult(result);
		}

		public FooId<T1> FooId1 { get; private set; }
		public FooId<T2> FooId2 { get; private set; }
		public FooId<T3> FooId3 { get; private set; }
		public FooId<T4> FooId4 { get; private set; }
		public FooId<T5> FooId5 { get; private set; }
		public FooId<T6> FooId6 { get; private set; }
		public FooId<T7> FooId7 { get; private set; }
		public FooId<T8> FooId8 { get; private set; }
		public FooId<T9> FooId9 { get; private set; }
		public FooId<T10> FooId10 { get; private set; }
		public FooId<T11> FooId11 { get; private set; }
		public FooId<T12> FooId12 { get; private set; }
		public FooId<T13> FooId13 { get; private set; }
		public FooId<T14> FooId14 { get; private set; }
		public FooId<T15> FooId15 { get; private set; }
		public FooId<T16> FooId16 { get; private set; }

	}

   

	
}
