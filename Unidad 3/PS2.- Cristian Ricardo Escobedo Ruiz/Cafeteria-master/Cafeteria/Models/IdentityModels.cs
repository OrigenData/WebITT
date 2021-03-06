﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ControlInventario.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Picture { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }



        public System.Data.Entity.DbSet<ControlInventario.Models.TypeCoffeeModels> TypeCoffeeModels { get; set; }

        public System.Data.Entity.DbSet<ControlInventario.Models.StatusOrderNameModels> StatusOrderNameModels { get; set; }

        public System.Data.Entity.DbSet<ControlInventario.Models.CoffeeModels> CoffeeModels { get; set; }

        public System.Data.Entity.DbSet<ControlInventario.Models.OrdersModels> OrdersModels { get; set; }
    }
}