using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Database;
using VMS.Domain.Database;

namespace VMS.Persistence
{
    public class PersistenceModule : Module
    {
        public string _connectionString;
        public string _migrationString;

        public PersistenceModule(string connectionString, string migrationString)
        {
            _connectionString = connectionString;
            _migrationString = migrationString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<VMSDbContext>()
                .AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationString", _migrationString)
                .InstancePerLifetimeScope();

            builder
                .RegisterType<VMSDbContext>()
                .As<IVMSDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationString", _migrationString)
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
