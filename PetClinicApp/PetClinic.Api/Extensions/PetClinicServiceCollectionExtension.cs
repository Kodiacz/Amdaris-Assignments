namespace Microsoft.Extensions.DependencyInjection
{
    public static class PetClinicServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection serviceCollection)
        {

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
