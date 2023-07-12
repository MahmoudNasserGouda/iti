using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WebApplication1.Models.EntitiesConfiguration;

namespace WebApplication1.Models.Entities
{
    // because we are trying to make our authentication worl
    public class BookStoreContext : IdentityDbContext<User>
    {
        public BookStoreContext()
        {
            
        }

        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ChapterConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserReviewConfiguration());
            builder.ApplyConfiguration(new UserCommentConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new UserSubscriptionConfiguration());
            builder.ApplyConfiguration(new UserBookConfiguration());
			builder.ApplyConfiguration(new ReportConfiguration());


			base.OnModelCreating(builder);
        }

        public virtual DbSet<Book> Books { get; set;}
        public virtual DbSet<Category> Categories { get; set;}
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<UserReview> UserReviews { get; set; }
        public virtual DbSet<UserComment> UserComments { get; set; }
        public virtual DbSet<UserSubscription> UserSubscriptions { get; set; }
        public virtual DbSet<UserBook> UserBooks { get; set; }
		public virtual DbSet<Report> Reports { get; set; }

	}
}
