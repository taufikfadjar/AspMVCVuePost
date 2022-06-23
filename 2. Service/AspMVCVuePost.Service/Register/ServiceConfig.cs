using AspMVCVuePost.Repository.Entities;
using Autofac;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVCVuePost.Service.Register
{
    public class ServiceConfig
    {
        public static ContainerBuilder Builder(ContainerBuilder builder)
        {
            builder.RegisterType<AppPostDbContext>().InstancePerRequest();

            builder.Register(c => new UserStore<User>(c.Resolve<AppPostDbContext>())).As<IUserStore<User>>().InstancePerRequest();
            builder.RegisterType<UserManager<User>>().InstancePerRequest();
            builder.Register(c => new RoleStore<IdentityRole>(c.Resolve<AppPostDbContext>())).As<IRoleStore<IdentityRole, string>>().InstancePerRequest();
            builder.RegisterType<RoleManager<IdentityRole>>().InstancePerRequest();

            builder.RegisterType<AccountService>().As<IAccountService>().InstancePerRequest();
            return builder;
        }
    }
}
