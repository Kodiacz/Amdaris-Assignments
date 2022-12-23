namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetDoctorByIdAsReadonlyHandler : IRequestHandler<GetDoctorByIdAsReadonly, Doctor>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetDoctorByIdAsReadonlyHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Doctor> Handle(
            GetDoctorByIdAsReadonly request, 
            CancellationToken cancellationToken)
        {
            return await this
                .unitOfWork
                .DoctorRepository
                .GetByIdAsReadonlyAsync(request.Id);
        }
    }
}
