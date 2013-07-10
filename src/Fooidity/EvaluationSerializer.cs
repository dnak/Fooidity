namespace Fooidity
{
    public class EvaluationSerializer
    {
        public string Serialize<T>(FooId<T> fooId) where T : FooId
        {
            return string.Format("{{\"{0}\":{{\"Enabled\":\"{1}\"}}}}", typeof(T).FullName, fooId.Enabled);
        }
    }
}