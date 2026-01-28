namespace Keeltekool.Migrations
{
    //using Keeltekool.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //internal sealed class Configuration : DbMigrationsConfiguration<Keeltekool.Models.ApplicationDbContext>
    //{
    //    public Configuration()
    //    {
    //        AutomaticMigrationsEnabled = false;
    //    }

    //    protected override void Seed(Keeltekool.Models.ApplicationDbContext context)
    //    {
    //        var roleStore = new RoleStore<IdentityRole>(context);
    //        var roleManager = new RoleManager<IdentityRole>(roleStore);
    //        var userStore = new UserStore<ApplicationUser>(context);
    //        var userManager = new UserManager<ApplicationUser>(userStore);



    //        string[] roles = { "Admin", "Opetaja", "Opilane" };

    //        foreach (var role in roles)
    //        {
    //            if (!roleManager.RoleExists(role))
    //            {
    //                roleManager.Create(new IdentityRole(role));
    //            }
    //        }
    //        var adminEmail = "Admin@kool.ee";
    //        var adminUser = context.Users.FirstOrDefault(u => u.Email == adminEmail);

    //        if (!context.Roles.Any(r => r.Name == "Admin"))
    //        {
    //            var role = new IdentityRole { Name = "Admin" };
    //            roleManager.Create(role);
    //        }

    //        if (adminUser == null)
    //        {
    //            var user = new ApplicationUser { UserName = adminEmail, Email = adminEmail };
    //            userManager.Create(user, "Admin_1234");
    //            adminUser = user;
    //        }

    //        if (!userManager.IsInRole(adminUser.Id, "Admin"))
    //        {
    //            userManager.AddToRole(adminUser.Id, "Admin");
    //        }

    //        if (!context.Roles.Any(r => r.Name == "Admin"))
    //        {
    //            var role = new IdentityRole { Name = "Admin" };
    //            roleManager.Create(role);
    //        }

    //    }
    //}
}
