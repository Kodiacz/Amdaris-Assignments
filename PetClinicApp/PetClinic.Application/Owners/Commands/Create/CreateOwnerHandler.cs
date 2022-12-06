namespace PetClinic.Owners.Commands.Create
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
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Phonenumber = request.Phonenumber,
            };

            await this.unitOfWorkRepo.OwnerRepository.AddAsync(owner);

            return owner;
        }
    }
}
