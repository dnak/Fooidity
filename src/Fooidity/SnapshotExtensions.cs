namespace Fooidity
{
    public static class SnapshotExtensions
    {
        public static Snapshot<T> Capture<T>(this FooId<T> fooId) where T : FooId
        {
            return new Snapshot<T>(fooId);
        }
    }
}