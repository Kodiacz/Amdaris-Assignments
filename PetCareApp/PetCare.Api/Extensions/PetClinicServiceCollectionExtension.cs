global using Microsoft.OpenApi.Models;
global using Swashbuckle.AspNetCore.Filters;

namespace Microsoft.Extensions.DependencyInjection
{

    public static class PetClinicServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection serviceCollection, WebApplicationBuilder builder)
        {
            //builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

            builder.Services
                .AddControllers(configuration =>
                {
                    configuration.Filters.AddApplicationFilters();
                })
                .AddNewtonsoftJson()
                .AddJsonOptions(x =>
                {
                    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standart Authorization header using the Bearer shceme",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                });

                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<PetCareDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            serviceCollection.AddCors(options =>
            {
                options.AddPolicy(name: "PetCare-FE", option =>
                {
                    option
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                        //.WithOrigins("http://localhost:3000");
                });
            });

            var jwtSettingsSection = builder.Configuration.GetSection("JwtSettings");
            serviceCollection.Configure<JwtSettings>(jwtSettingsSection);

            var jwtSettings = jwtSettingsSection.Get<JwtSettings>();
            var key = System.Text.Encoding.UTF8.GetBytes(jwtSettings.Secret);
            serviceCollection.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };
            });

            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IDoctorRepository, DoctorRepository>();
            serviceCollection.AddScoped<IReceptionistRepository, ReceptionistRepository>();
            serviceCollection.AddScoped<IOwnerRepository, OwnerRepository>();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();

            serviceCollection.AddMediatR(typeof(IDoctorRepository));
            serviceCollection.AddMediatR(typeof(IReceptionistRepository));
            serviceCollection.AddMediatR(typeof(IOwnerRepository));
            serviceCollection.AddMediatR(typeof(IPetRepository));

            serviceCollection.AddAutoMapper(typeof(Program));

            return serviceCollection;
        }
    }
}
