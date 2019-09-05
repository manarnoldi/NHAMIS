using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NHAMIS.APP.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHAMIS.APP.Startup))]
namespace NHAMIS.APP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRole();
        }

        public void CreateRole()
        {
            NHAMISContext context = new NHAMISContext();
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if(!rolemanager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                rolemanager.Create(role);
            }
            if(!rolemanager.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                rolemanager.Create(role);
            }
        }
    }
}
