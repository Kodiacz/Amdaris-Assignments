namespace PetCare.Infrastructure
{
    using PetCare.Application.Interfaces;
    using PetCare.Interfaces;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly PetCareDbContext context;

        public UnitOfWork() { }

        public UnitOfWork(
            PetCareDbContext context, 
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

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
