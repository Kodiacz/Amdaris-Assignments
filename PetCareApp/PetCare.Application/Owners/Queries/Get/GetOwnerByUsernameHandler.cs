namespace PetCare.Application.Owners.Queries.Get
{
    public class GetOwnerByUsernameHandler : IRequestHandler<GetOwnerByUsername, Owner>
    {
        private readonly IUnitOfWork repo;

        public GetOwnerByUsernameHandler(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        public async Task<Owner> Handle(GetOwnerByUsername request, CancellationToken cancellationToken)
        {
            Owner owner = await this.repo
                .OwnerRepository
                .GetOwnerByUsername(request.Username, o => !o.IsDeleted) 
                ?? throw new ArgumentNullException($"The {nameof(Owner)} with {request.Username} Username does not exist"); 

            return owner;
        }
    }
}
