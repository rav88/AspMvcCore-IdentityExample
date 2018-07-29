using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IdentityExample.Identity
{
    public class EFCContext : IdentityDbContext
    {
	    public EFCContext(DbContextOptions opt) : base(opt)
	    {

	    }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			var loggerFactory = new LoggerFactory();
			loggerFactory.AddProvider(new LoggerProvider());
			optionsBuilder.UseLoggerFactory(loggerFactory);
		}
	}
}
