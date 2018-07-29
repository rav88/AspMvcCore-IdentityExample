using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityExample.Identity
{
    public class EFCContext : IdentityDbContext
    {
	    public EFCContext(DbContextOptions opt) : base(opt)
	    {

	    }
    }
}
