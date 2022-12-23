using PetCare.Application.Pets.Queries.Get;

namespace PetCare.Application.Pets.Queries.Get
{
    public class GetPetByIdAsReadonlyHandler : IRequestHandler<GetPetByIdAsReadonly, Pet>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetPetByIdAsReadonlyHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Pet> Handle(
            GetPetByIdAsReadonly request,
            CancellationToken cancellationToken)
        {
            return await this
                .unitOfWork
                .PetRepository
                .GetByIdAsReadonlyAsync(request.Id);
        }
    }
}
