namespace Moviesite
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Moviesite.Data;
    using Moviesite.Service;
    using Moviesite.Service.Interfaces;
    using Moviestore.Repository;
    using Moviestore.Repository.Interfaces;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //DATA CONTEXT
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MoviesiteConnection")));

            //IDENTITY
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<DataContext>();

            //MVC
            services.AddControllersWithViews();

            //RAZOR
            services.AddRazorPages();

            //REPOSITORIES
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<IProducerRepository, ProducerRepository>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IWishlistRepository, WishlistRepository>();
            services.AddTransient<IShoppingCartRepository, ShoppingCartRepository>();
            services.AddTransient<IDirectorRepository, DirectorRepository>();
            services.AddTransient<IActorRepository, ActorRepository>();
            services.AddTransient<IMovieActorRepository, MovieActorRepository>();

            //SERVICES
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IProducerService, ProducerService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IWishlistService, WishlistService>();
            services.AddTransient<IShoppingCartService, ShoppingCartService>();
            services.AddTransient<IDirectorService, DirectorService>();
            services.AddTransient<IActorService, ActorService>();
            services.AddTransient<IMovieActorService, MovieActorService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
