namespace PetCare.Application.Owners.Commands.Update
{
    public class UpdateOwnerHandler : IRequestHandler<UpdateOwner, Owner>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public UpdateOwnerHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Owner> Handle(UpdateOwner request, CancellationToken cancellationToken)
        {
            Owner owner = new Owner
            {
                Id = request.Id,
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
