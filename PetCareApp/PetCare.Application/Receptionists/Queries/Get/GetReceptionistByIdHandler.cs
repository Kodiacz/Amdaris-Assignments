namespace PetCare.Application.Receptionists.Queries.Get
{
    public class GetReceptionistByIdHandler : IRequestHandler<GetReceptionistById, Receptionist>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetReceptionistByIdHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Receptionist> Handle(GetReceptionistById request, CancellationToken cancellationToken)
        {
            return await unitOfWorkRepo.ReceptionistRepository.GetByIdAsync(request.Id)
                ?? throw new ArgumentNullException($"The {nameof(Receptionist)} with Id {request.Id} does not exist"); ;
        }
    }
}
