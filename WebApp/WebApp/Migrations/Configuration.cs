namespace WebApp.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApp.Persistence.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApp.Persistence.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
      
           
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Controller"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Controller" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "AppUser"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "AppUser" };

                manager.Create(role);
            }

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.UserName == "admin@yahoo.com"))
            {
                var user = new ApplicationUser() { Id = "admin", UserName = "admin@yahoo.com", Email = "admin@yahoo.com", PasswordHash = ApplicationUser.HashPassword("Admin123!") };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "appu@yahoo.com"))
            { 
                var user = new ApplicationUser() { Id = "appu", UserName = "appu@yahoo.com", Email = "appu@yahoo.com", PasswordHash = ApplicationUser.HashPassword("Appu123!") };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "AppUser");
            }


           /* var vremenska = new ArhivaCenovnika() { Id = 0, From = DateTime.Now, To = new DateTime(2019, 7, 5, 12, 0, 0), Tip = TipKarte.Vremenska, Cena = 65 };
            context.ArhivaCenovnikas.Add(vremenska);
            context.SaveChanges();

            var dnevna = new ArhivaCenovnika() { Id = 1, From = DateTime.Now, To = new DateTime(2019, 7, 5, 12, 0, 0), Tip = TipKarte.Dnevna, Cena = 300 };
            context.ArhivaCenovnikas.Add(dnevna);
            context.SaveChanges();

            var mesecna = new ArhivaCenovnika() { Id = 2, From = DateTime.Now, To = new DateTime(2019, 7, 5, 12, 0, 0), Tip = TipKarte.Mesecna, Cena = 1000 };
            context.ArhivaCenovnikas.Add(mesecna);
            context.SaveChanges();

            var godisnja = new ArhivaCenovnika() { Id = 3, From = DateTime.Now, To = new DateTime(2019, 7, 5, 12, 0, 0), Tip = TipKarte.Godisnja, Cena = 12000 };
            context.ArhivaCenovnikas.Add(godisnja);
            context.SaveChanges();
            */
        }
    }
}
