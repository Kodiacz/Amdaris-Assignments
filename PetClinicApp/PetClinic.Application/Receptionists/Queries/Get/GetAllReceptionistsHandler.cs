namespace PetClinic.Application.Receptionists.Queries.Get
{
    public class GetAllReceptionistsHandler : IRequestHandler<GetAllReceptionists, List<Receptionist>>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetAllReceptionistsHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<List<Receptionist>> Handle(GetAllReceptionists request, CancellationToken cancellationToken)
        {
            return await unitOfWorkRepo.ReceptionistRepository.GetAllAsync();
        }
    }
}
