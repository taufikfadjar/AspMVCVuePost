using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AspMVCVuePost.Repository.Entities
{
    public partial class AppPostDbContext : IdentityDbContext<User>
    {
        public AppPostDbContext()
            : base("name=AppPostDbContext")
        {
        }

        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Slug)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .ToTable("User");

            modelBuilder.Entity<IdentityRole>()
                .ToTable("Role");

            modelBuilder.Entity<IdentityUserRole>()
                .ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserClaim>()
                .ToTable("UserClaims");

            modelBuilder.Entity<IdentityUserLogin>()
                .ToTable("UserLogins");

            modelBuilder.Entity<Post>()
               .HasRequired(c => c.User)
               .WithMany(p => p.Posts)
               .HasForeignKey(c => c.AuthorUserId);

        }
    }
}
