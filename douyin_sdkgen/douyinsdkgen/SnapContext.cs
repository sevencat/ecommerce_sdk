using Microsoft.EntityFrameworkCore;

namespace douyinsdkgen;

public class SnapContext : DbContext
{
	public DbSet<DouyinSdkItem> DouyinSdkItems { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		var exedir = AppDomain.CurrentDomain.BaseDirectory;
		var dbfn = Path.Combine(exedir, "sdk_douyin.db");
		if (!File.Exists(dbfn))
		{
			File.Create(dbfn).Close();
		}

		options.UseSqlite($"Data Source={dbfn}");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<DouyinSdkItem>();
	}
}