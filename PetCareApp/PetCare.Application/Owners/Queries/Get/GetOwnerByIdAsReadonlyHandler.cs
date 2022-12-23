using PetCare.Application.Owners.Queries.Get;

namespace PetCare.Application.Owners.Queries.Get
{
    public class GetOwnerByIdAsReadonlyHandler : IRequestHandler<GetOwnerByIdAsReadonly, Owner>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetOwnerByIdAsReadonlyHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Owner> Handle(
            GetOwnerByIdAsReadonly request,
            CancellationToken cancellationToken)
        {
            return await this
                .unitOfWork
                .OwnerRepository
                .GetByIdAsReadonlyAsync(request.Id);
        }
    }
}
