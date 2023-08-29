using Blog.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog
{
	public class BlogDbContext : DbContext
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
		{
		}

		public DbSet<Post> posts { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<PostDraft> postDrafts {get; set;}




		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	IConfigurationBuilder configbuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
		//	IConfiguration configuration = configbuilder.Build();
		//	var conn = configuration.GetConnectionString("DefaultConnection");

		//	optionsBuilder.UseSqlServer(conn);

		//}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Post>().HasKey(vf => new { vf.PostId });
			modelBuilder.Entity<User>().HasKey(vf => new {  vf.UserId });

		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//    modelBuilder.Entity<User>().HasKey(vf => new { vf.Id });
		//}
	}
}
