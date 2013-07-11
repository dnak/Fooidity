using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;

namespace Fooidity.AutofacIntegration
{
    public class AutoFacDependentFooIdBuilder<T> : IDependentFooIdBuilder<T> where T : FooId
    {
        private readonly IComponentContext _scope;

        public AutoFacDependentFooIdBuilder(IComponentContext scope)
        {
            _scope = scope;
        }

        public FooId<T> BuildFooId()
        {
            var interfaces = typeof (T).GetInterfaces();
            var dependentEvaluations = new List<Func<bool>> { () => true };
            
            foreach (var i in interfaces.Where(i => i.IsGenericType))
            {
                Type genericTypeDefinition = i.GetGenericTypeDefinition();
                //if (genericTypeDefinition == typeof (When<>))
                //{
                //    dependentEvaluations.Add(BuildEvaluation(i, InvokeEnabled));
                //}
                //else if (genericTypeDefinition == typeof (Unless<>))
                //{
                //    dependentEvaluations.Add(BuildEvaluation(i, InvokeOppositeOfEnabled));
                //}
            }

            Func<bool> fullEvaluation = () => dependentEvaluations.All(evaluation => evaluation());

            return new DeferredEvaluation<T>(fullEvaluation);
        }
        
        private Func<bool> BuildEvaluation(Type interfaceType, 
            Func<object,Type,Func<bool>> evaluationInvocation)
        {
            Type[] fooIdType = interfaceType.GetGenericArguments();
            Type fooIdInstanceType = typeof(FooId<>).MakeGenericType(fooIdType);
            var instance = _scope.Resolve(fooIdInstanceType);
            return evaluationInvocation(instance, fooIdInstanceType);
        }

        private Func<bool> InvokeOppositeOfEnabled(object instance, Type fooIdInstanceType)
        {
            return () => !InvokeEnabled(instance, fooIdInstanceType)();
        }

        private Func<bool> InvokeEnabled(object instance, Type fooIdInstanceType)
        {
            return () => (bool) fooIdInstanceType.InvokeMember("Enabled",
                                                               BindingFlags.Public | BindingFlags.GetProperty |
                                                               BindingFlags.Instance,
                                                               null,
                                                               instance,
                                                               new object[0]);
        }
    }
}