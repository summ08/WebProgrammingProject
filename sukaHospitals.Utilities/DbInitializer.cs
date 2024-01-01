using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SukaHospital.Models;
using sukaHospital.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospitals.Utilities
{
    public class DbInitializer : IDbInitializer
    {
        private UserManager<IdentityUser> _userManager;

        

        private ApplicationDbContext _context;
        private RoleManager<IdentityRole> _roleManager;
        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public void Initialize()

        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count()>0)
                {
                        _context.Database.Migrate();
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (!_roleManager.RoleExistsAsync(WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult()) 
            {
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Hasta)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Doktor)).GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "sau",
                    Email = "B211210065@ogr.sakarya.edu.tr"

                },"sau@123").GetAwaiter().GetResult(); 

                var Appuser = _context.ApplicationUser.FirstOrDefault(x =>
                x.Email == "B211210065@ogr.sakarya.edu.tr");

                if (Appuser != null)
                {
                    _userManager.AddToRoleAsync(Appuser,WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult();
                }

            }
        }
    }
}
