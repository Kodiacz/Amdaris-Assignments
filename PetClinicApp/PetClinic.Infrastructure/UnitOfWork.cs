namespace PetClinic.Infrastructure
{
    using PetClinic.Application.Interfaces;
    using PetClinic.Interfaces;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        public IDoctorRepository DoctorRepository { get; private set; }

        public IOwnerRepository OwnerRepository { get; private set; }

        public IPetRepository PetRepository { get; private set; }

        public IReceptionistRepository ReceptionistRepository { get; private set; }

        public void Dispose()
        {
            ;
        }

        public Task Save()
        {
            ;
        }
    }
}
