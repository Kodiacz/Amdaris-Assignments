namespace PetClinic.Application.Receptionists.Queries.Get
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
            return await unitOfWorkRepo.ReceptionistRepository.GetByIdAsync(request.Id)
                ?? throw new ArgumentNullException($"The {nameof(Receptionist)} with Id {request.Id} does not exist"); ;
        }
    }
}
