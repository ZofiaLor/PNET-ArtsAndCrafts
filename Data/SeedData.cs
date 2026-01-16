using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace ArtsAndCrafts.Data;

public class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        using var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        if (context == null || context.ApplicationUsers == null)
        {
            throw new NullReferenceException(
                "Null ApplicationDbContext or ApplicationUsers DbSet");
        }

        if (! await roleManager.RoleExistsAsync("Admin"))
        {
            var role = new IdentityRole("Admin");
            await roleManager.CreateAsync(role);
        }

        if (context.ApplicationUsers.Any())
        {
            return;
        }

        var user = new ApplicationUser
        {
            UserName = "admin",
            Email = "admin@admin.com",
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(user, "Admin!123");
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Admin");
        }

    }
}
