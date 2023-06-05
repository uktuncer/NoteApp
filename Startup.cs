namespace NoteApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add serices to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            AppSettings appSettings = Configuration.GetSection("AppSettings").Get<AppSettings>();
            DatabaseInitializer databaseInitializer = new DatabaseInitializer(new Models.Context.DatabaseContext(), appSettings);
            databaseInitializer.Seed();
        }

  
  

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
        }
    }
}
