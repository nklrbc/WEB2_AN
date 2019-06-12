namespace WebApp.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
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


            /*var vremenska = new ArhivaCenovnika() { Id = 0, From = DateTime.Now, To = new DateTime(2019, 7, 5, 12, 0, 0), Tip = TipKarte.Vremenska, Cena = 65 };
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
            context.SaveChanges();*/


            /*List<string> vremena1 = new List<string>();
            vremena1.Add("8:40");
            vremena1.Add("9:50");
            vremena1.Add("12:00");
            vremena1.Add("13:50");
            vremena1.Add("14:30");
            vremena1.Add("15:50");
            var linija1 = new Linija(1, "Jedinica", vremena1);

            var stanica1 = new Stanica(0, "Zeleznica stanica");
            var stanica2 = new Stanica(1, "Safarikova");
            var stanica3 = new Stanica(2, "Brace Ribnikar");
            var stanica4 = new Stanica(3, "Merkator");
            var stanica5 = new Stanica(4, "Most Slobode");
            var stanica6 = new Stanica(5, "Sremska Kamenica"); 

            stanica1.Linije.Add(linija1);
            stanica2.Linije.Add(linija1);
            stanica3.Linije.Add(linija1);
            stanica4.Linije.Add(linija1);
            stanica5.Linije.Add(linija1);
            stanica6.Linije.Add(linija1);

            linija1.Stanice.Add(stanica1);
            linija1.Stanice.Add(stanica2);
            linija1.Stanice.Add(stanica3);
            linija1.Stanice.Add(stanica4);
            linija1.Stanice.Add(stanica5);
            linija1.Stanice.Add(stanica6);

            context.Stanicas.Add(stanica1);
            context.Stanicas.Add(stanica2);
            context.Stanicas.Add(stanica3);
            context.Stanicas.Add(stanica4);
            context.Stanicas.Add(stanica5);
            context.Stanicas.Add(stanica6);

            context.Linijas.Add(linija1);

            context.SaveChanges();*/

            /*List<string> vremena1 = new List<string>();

            vremena1.Add("8:45");
            vremena1.Add("9:55");
            vremena1.Add("12:05");
            vremena1.Add("13:55");
            vremena1.Add("14:35");
            vremena1.Add("15:55");
            var linija1 = new Linija(3, "Trojka", vremena1);

            var stanica1 = new Stanica(0, "Zeleznica stanica");
            var stanica2 = new Stanica(1, "Safarikova");
            var stanica3 = new Stanica(2, "Centar");
            var stanica4 = new Stanica(3, "Univerzitet");
            var stanica5 = new Stanica(4, "Kej"); 

            stanica1.Linije.Add(linija1);
            stanica2.Linije.Add(linija1);
            stanica3.Linije.Add(linija1);
            stanica4.Linije.Add(linija1);
            stanica5.Linije.Add(linija1);

            linija1.Stanice.Add(stanica1);
            linija1.Stanice.Add(stanica2);
            linija1.Stanice.Add(stanica3);
            linija1.Stanice.Add(stanica4);
            linija1.Stanice.Add(stanica5);

            context.Stanicas.Add(stanica1);
            context.Stanicas.Add(stanica2);
            context.Stanicas.Add(stanica3);
            context.Stanicas.Add(stanica4);
            context.Stanicas.Add(stanica5);

            context.Linijas.Add(linija1);

            context.SaveChanges();*/

        }
    }
}
