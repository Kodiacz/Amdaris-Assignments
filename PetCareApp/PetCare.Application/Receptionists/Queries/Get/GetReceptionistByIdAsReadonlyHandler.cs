using PetCare.Application.Receptionists.Queries.Get;

namespace PetCare.Application.Receptionists.Queries.Get
{
    public class GetReceptionistByIdAsReadonlyHandler : IRequestHandler<GetReceptionistByIdAsReadonly, Receptionist>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetReceptionistByIdAsReadonlyHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Receptionist> Handle(
            GetReceptionistByIdAsReadonly request,
            CancellationToken cancellationToken)
        {
            return await this
                .unitOfWork
                .ReceptionistRepository
                .GetByIdAsReadonlyAsync(request.Id);
        }
    }
}
