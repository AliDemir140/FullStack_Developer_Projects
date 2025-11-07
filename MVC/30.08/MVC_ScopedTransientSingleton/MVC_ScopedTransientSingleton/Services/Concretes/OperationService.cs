using MVC_ScopedTransientSingleton.Services.Abstracts;

namespace MVC_ScopedTransientSingleton.Services.Concretes
{
    public class OperationService : ITransientService,IScopedService,ISingletonService
    {
        private Guid _id;

        public OperationService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetGuid()
        {
            return _id;
        }
    }
}
