using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.BackgroundServices;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //configuration for the connection string 
            var configuration = new ConfigurationBuilder()
           .SetBasePath(builder.Environment.ContentRootPath)
           .AddJsonFile("appsettings.json", optional: false)
           .Build();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // ctor injection of context
            builder.Services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //adding our entities scopes
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IChapterRepository, ChapterRepository>();
            builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
            builder.Services.AddScoped<IUserReviewRepository, UserReviewRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ICommentRepository, CommentRepository>();
            builder.Services.AddScoped<IUserCommentRepository, UserCommentRepository>();
            builder.Services.AddScoped<IUserSubscriptionRepository, UserSubscriptionRepository>();
			builder.Services.AddScoped<IReportRepository, ReportRepository>();
			builder.Services.AddScoped<IEmailService, EmailService>();

			// to add our signinmanager and usermanager
			builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<BookStoreContext>();
            builder.Services.AddScoped<UserManager<User>>();

            // Register subscriptions Background service
            builder.Services.AddHostedService<SubscriptionsBackgroundService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=MainMenu}/{action=MainMenu}/{id?}");

            app.MapControllerRoute(
                name: "Categories",
                pattern: "Categories/{action=Categories}/{id?}",
                defaults: new { controller = "Categories", action = "Categories" });

            app.Run();
        }
    }
}