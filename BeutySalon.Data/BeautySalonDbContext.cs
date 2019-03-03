namespace BeautySalon.Data
{
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;

	public class BeautySalonDbContext : IdentityDbContext
	{
		public BeautySalonDbContext(DbContextOptions<BeautySalonDbContext> options)
			: base(options)
		{
		}
	}
}
