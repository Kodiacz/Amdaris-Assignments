using PetCare.Application.Owners.Commands.Update;

namespace PetCare.Application.Owners.Commands.PartialUpdate
{
    public class PartialUpdateOwnerHandler : IRequestHandler<PartialUpdateOwner, Owner>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public PartialUpdateOwnerHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Owner> Handle(PartialUpdateOwner request, CancellationToken cancellationToken)
        {
            Owner owner = new Owner
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Phonenumber = request.Phonenumber,
            };

            await this.unitOfWorkRepo.OwnerRepository.UpdateAsync(owner);
            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
