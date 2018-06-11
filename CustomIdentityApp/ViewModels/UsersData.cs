using Microsoft.AspNetCore.Identity;
using CustomIdentityApp.Models;
using System.Threading.Tasks;
using System.Linq;

namespace RolesInitializerApp
{
    public class UsersData
    {
        public static async void InitializeAsync(ApplicationContext context, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            //if (await roleManager.FindByNameAsync("admin") == null)
            //{
            //    IdentityResult result1 = await roleManager.CreateAsync(new IdentityRole("admin"));
            //}

            //if (!context.Users.Any())
            //{

            //    string adminEmail = "admin@gmail.com";
            //    string password = "Pavlo123!";
            //    User admin = new User { Email = adminEmail, UserName = adminEmail };
            //    IdentityResult result = await userManager.CreateAsync(admin, password);

            //    await userManager.AddToRoleAsync(admin,"admin");

            //    context.SaveChanges();
            //}
            ////////////////////////////////////////////////////////////

            /*
            string adminEmail = "admin@gmail.com";
            string password = "Pavlo123!";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail };
                IdentityResult result = await userManager.CreateAsync(admin , password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
            */
        }
    }
}