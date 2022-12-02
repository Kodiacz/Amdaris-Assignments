using PetClinic.Interfaces;

namespace PetClinic.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IDoctorRepository DoctorRepository { get; }

        public IOwnerRepository OwnerRepository { get; }

        public IPetRepository PetRepository { get; }

        public IReceptionistRepository ReceptionistRepository { get; }

        Task SaveAsync();
    }
}
