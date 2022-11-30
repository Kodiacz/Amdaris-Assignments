namespace PetClinic.Infrastructure
{
    using PetClinic.Application.Interfaces;
    using PetClinic.Interfaces;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly PetClinicDbContext context;

        public UnitOfWork(
            PetClinicDbContext context, 
            IDoctorRepository doctorRepository, 
            IOwnerRepository ownerRepository, 
            IPetRepository petRepository, 
            IReceptionistRepository receptionistRepository)
        {
            this.context = context;
            DoctorRepository = doctorRepository;
            OwnerRepository = ownerRepository;
            PetRepository = petRepository;
            ReceptionistRepository = receptionistRepository;
        }

        public IDoctorRepository DoctorRepository { get; private set; }

        public IOwnerRepository OwnerRepository { get; private set; }

        public IPetRepository PetRepository { get; private set; }

        public IReceptionistRepository ReceptionistRepository { get; private set; }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public async Task Save()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
