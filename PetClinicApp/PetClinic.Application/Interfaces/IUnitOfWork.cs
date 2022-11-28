using PetClinic.Interfaces;

namespace PetClinic.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IDoctorRepository DoctorRepository { get; set; }

        public IOwnerRepository OwnerRepository { get; set; }

        public IPetRepository PetRepository { get; set; }

        Task Save();
    }
}
