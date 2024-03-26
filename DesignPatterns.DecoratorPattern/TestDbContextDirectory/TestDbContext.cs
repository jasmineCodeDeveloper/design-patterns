using System.Data.Entity;

namespace DesignPatterns.DecoratorPattern.TestDbContextDirectory
{
	public class TestDbContext : DbContext
	{
		public DbSet<UserEntity> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public override int SaveChanges()
		{
			return base.SaveChanges();
		}
	}
	
}
