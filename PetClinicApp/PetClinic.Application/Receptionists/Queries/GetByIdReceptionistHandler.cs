namespace PetClinic.Application.Receptionists.Queries
{
    public class GetByIdReceptionistHandler : IRequestHandler<GetByIdReceptionist, Receptionist>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetByIdReceptionistHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Receptionist> Handle(GetByIdReceptionist request, CancellationToken cancellationToken)
        {
            return await this.unitOfWorkRepo.ReceptionistRepository.GetByIdAsync(request.Id);
        }
    }
}
