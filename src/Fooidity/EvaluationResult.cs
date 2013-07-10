
namespace Fooidity
{
    public class EvaluationResult
    {
        public EvaluationResult(string results)
        {
            Results = results;
        }

        public string Results { get; private set; }
    }
}
