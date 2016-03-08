using HealthService.Core.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace HealthService.Data
{
    public class BigBangInitializer : DropCreateDatabaseIfModelChanges<HealthServiceDbContext>
    {
        protected override void Seed(HealthServiceDbContext context)
        {
            Initialize(context);
            base.Seed(context);
        }

        public void Initialize(HealthServiceDbContext context)
        {
            try
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!roleManager.RoleExists("Admin"))
                {
                    roleManager.Create(new IdentityRole("Admin"));
                }

                if (!roleManager.RoleExists("Member"))
                {
                    roleManager.Create(new IdentityRole("Member"));
                }

                var user = new ApplicationUser()
                {
                    Email = "smh_bas@hotmail.com",
                    UserName = "smh_bas@hotmail.com",
                    FirstName = "Semih",
                    LastName = "Bas"
                };

                var userResult = userManager.Create(user, "Admin@123");

                if (userResult.Succeeded)
                {
                    userManager.AddToRole<ApplicationUser, string>(user.Id, "Admin");
                }

                context.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}