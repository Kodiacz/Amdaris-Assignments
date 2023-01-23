namespace PetCare.Application.Owners.Queries.Get
{
    public class GetAllOwnerAppointmentsHandler : IRequestHandler<GetAllOwnerAppointments, List<Appointment>>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetAllOwnerAppointmentsHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<List<Appointment>> Handle(GetAllOwnerAppointments request, CancellationToken cancellationToken)
        {
            return await this.unitOfWorkRepo.OwnerRepository.GetAllOwnerAppointments(request.OwnerId);
        }
    }
}
