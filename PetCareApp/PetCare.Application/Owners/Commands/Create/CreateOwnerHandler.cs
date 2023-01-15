namespace PetCare.Application.Owners.Commands.Create
{
    public class CreateOwnerHandler : IRequestHandler<CreateOwner, Owner>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public CreateOwnerHandler(IUnitOfWork ownerRepository)
        {
            this.unitOfWorkRepo = ownerRepository;
        }

        public async Task<Owner> Handle(CreateOwner request, CancellationToken cancellationToken)
        {
            Owner owner = new Owner
            {
                Username = request.Username,
                PasswordHash = request.PasswordHash,
                PasswordSalt = request.PasswordSalt,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phonenumber = request.Phonenumber,
            };

            await this.unitOfWorkRepo.OwnerRepository.AddAsync(owner);
            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
