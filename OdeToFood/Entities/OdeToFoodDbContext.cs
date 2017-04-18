using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Entities
{
    public class OdeToFoodDbContext : IdentityDbContext<User>
    {
        public OdeToFoodDbContext()
        {
        }

        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options) : base(options)
        {}

        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Friend> Friends { get; set; }

        //public DbSet<Friend> Friends { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Friend>()
        //        .HasOne(f => f.User)
        //        .WithMany(f => f.Friends)
        //        .HasForeignKey(f => new { f.User.Id, f.FriendId });

        //    base.OnModelCreating(builder);
        //}
    }
}
