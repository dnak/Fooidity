using Autofac;

namespace Fooidity.AutofacIntegration
{
    public class AutofacResolver : Resolver
    {
        private readonly IComponentContext _context;

        public AutofacResolver(IComponentContext context)
        {
            _context = context;
        }

        public FooId<T> Resolve<T>() where T : FooId
        {
            return _context.Resolve<FooId<T>>();
        }
    }
}