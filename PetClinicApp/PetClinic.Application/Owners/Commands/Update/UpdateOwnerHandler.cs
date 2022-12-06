namespace PetClinic.Application.Owners.Commands.Update
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
                Age = request.Age,
                Phonenumber = request.Phonenumber,
            };         

            await this.unitOfWorkRepo.OwnerRepository.UpdateAsync(owner);
            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
