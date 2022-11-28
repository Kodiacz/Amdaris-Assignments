namespace PetClinic.Application.Interfaces
{
    using PetClinic.Domain.Entities;

    public interface IDoctorRepository
    {
        void CreateDoctor(Doctor doctor);
    }
}
