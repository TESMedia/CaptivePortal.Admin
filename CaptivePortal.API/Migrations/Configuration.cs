namespace CaptivePortal.API.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CaptivePortal.API.Context.AdminManagementDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CaptivePortal.API.Context.AdminManagementDbContext";
        }

        protected override void Seed(CaptivePortal.API.Context.AdminManagementDbContext context)
        {


            IList<Role> roles = new List<Role>();

            roles.Add(new Role() { RoleName = "GAdmin", RoleId = 1 });
            roles.Add(new Role() { RoleName = "CaptivePortalAdmin", RoleId = 2 });
            roles.Add(new Role() { RoleName = "User", RoleId = 3 });

            foreach (Role role in roles)
                context.Roles.Add(role);

            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
