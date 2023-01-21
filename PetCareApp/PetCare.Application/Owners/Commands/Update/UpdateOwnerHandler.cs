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
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phonenumber = request.Phonenumber,
                ProfileImageFilePath = request.ProfileImageFilePath,
            };         

            await this.unitOfWorkRepo.OwnerRepository.UpdateAsync(owner);
            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
