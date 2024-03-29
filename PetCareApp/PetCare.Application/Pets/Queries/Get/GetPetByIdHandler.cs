﻿namespace PetCare.Application.Pets.Queries.Get
{
    public class GetPetByIdHandler : IRequestHandler<GetPetById, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetPetByIdHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(GetPetById request, CancellationToken cancellationToken)
        {
            return await unitOfWorkRepo.PetRepository.GetByIdAsync(request.Id)
                ?? throw new ArgumentNullException($"The {nameof(Pet)} with Id {request.Id} does not exist"); ;
        }
    }
}
