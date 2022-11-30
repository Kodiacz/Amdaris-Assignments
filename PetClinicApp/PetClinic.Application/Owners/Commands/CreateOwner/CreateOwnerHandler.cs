namespace PetClinic.Owners.Commands.CreateOwner
{
    using MediatR;
    using PetClinic.Interfaces;
    using PetClinic.Domain.Entities;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateOwnerHandler : IRequestHandler<CreateOwnerCommand, int>
    {
        private readonly IOwnerRepository _ownerRepository;

        public CreateOwnerHandler(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public Task<int> Handle(CreateOwnerCommand request, CancellationToken cancellationToken)
        {
            Owner owner = new Owner
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Phonenumber = request.Phonenumber,
            };


            return Task.FromResult(owner.Id);
        }
    }
}
