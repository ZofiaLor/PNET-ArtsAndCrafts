using ArtsAndCrafts.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtsAndCrafts.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CraftObject> CraftObjects { get; set; }
        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<PatternUser> PatternUsers { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<ToolUser> ToolUsers { get; set; }
        public DbSet<Yarn> Yarns { get; set; }
        public DbSet<YarnUser> YarnUsers { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Comment>().HasOne(x => x.CraftObject);
            builder.Entity<Comment>().HasOne(x => x.Author).WithMany(x => x.Comments).HasForeignKey(x => x.AuthorId).OnDelete(DeleteBehavior.ClientSetNull);
            //builder.Entity<CraftObject>().HasMany(x => x.Comments).WithOne(x => x.CraftObject).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<CraftObject>();
            builder.Entity<Pattern>().HasMany(x => x.Yarns).WithMany(x => x.Patterns);
            builder.Entity<Pattern>().HasMany(x => x.Tools).WithMany(x => x.Patterns);
            builder.Entity<PatternUser>().HasKey(q => new { q.PatternId, q.UserId });
            builder.Entity<PatternUser>().HasOne(x => x.User).WithMany(x => x.BookmarkedPatterns).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Picture>().HasOne(x => x.CraftObject);
            builder.Entity<Tag>().HasMany(x => x.Patterns).WithMany(x => x.Tags);
            builder.Entity<Tool>();
            builder.Entity<ToolUser>().HasKey(q => new {q.ToolId, q.UserId});
            builder.Entity<ToolUser>().HasOne(x => x.User).WithMany(x => x.BookmarkedTools).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Yarn>();
            builder.Entity<YarnUser>().HasKey(q => new {q.YarnId, q.UserId});
            builder.Entity<YarnUser>().HasOne(x => x.User).WithMany(x => x.BookmarkedYarns).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<ApplicationUser>();
            //builder.Entity<ApplicationUser>().HasMany(q => q.Comments).WithOne(q => q.Author).OnDelete(DeleteBehavior.ClientSetNull);
        }

    }


}
