using Authentication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Context;

public class ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : IdentityDbContext<User>(options)
{
}
