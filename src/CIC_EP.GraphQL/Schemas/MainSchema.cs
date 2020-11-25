using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using CIC_EP.Queries.Container;

namespace CIC_EP.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}