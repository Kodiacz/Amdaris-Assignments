namespace PetClinic.Infrastructure
{
    using PetClinic.Application.Interfaces;
    using PetClinic.Interfaces;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        public IDoctorRepository DoctorRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOwnerRepository OwnerRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPetRepository PetRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
