namespace PetClinic.Application.Doctors.Queries.Get
{
    using MediatR;

    using PetClinic.Application.Interfaces;
    using PetClinic.Domain.Entities;

    public class GetDoctorByIdHandler : IRequestHandler<GetDoctorById, Doctor>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetDoctorByIdHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Doctor> Handle(GetDoctorById request, CancellationToken cancellationToken)
        {
            return await this.unitOfWorkRepo.DoctorRepository.GetByIdAsync(request.Id);
        }
    }
}
