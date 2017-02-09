using Ninject.Modules;
using Vocabulary.DAL.Interfaces;
using Vocabulary.DAL.UnitsOfWork;

namespace Vocabulary.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private readonly string _connectionString;

        public ServiceModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(_connectionString);
        }
    }
}
