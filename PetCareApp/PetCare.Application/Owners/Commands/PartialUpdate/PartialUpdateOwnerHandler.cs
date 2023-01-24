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
                Username = request.Username,
                Phonenumber = request.Phonenumber,
                PasswordHash = request.PasswordHash,
                PasswordSalt = request.PasswordSalt,
                ProfileImageFilePath = request.ProfileImageFilePath,
                Email = request.Email,
            };

            await this.unitOfWorkRepo.OwnerRepository.UpdateAsync(owner);
            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
