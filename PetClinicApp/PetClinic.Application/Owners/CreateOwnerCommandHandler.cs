using MediatR;

namespace PetClinic.Application.Owners
{
    public class CreateOwnerCommandHandler : IRequestHandler<CreateOwnerCommand, int>
    {
        public Task<int> Handle(CreateOwnerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
