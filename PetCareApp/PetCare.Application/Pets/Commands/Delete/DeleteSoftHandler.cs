﻿namespace PetCare.Application.Pets.Commands.Delete
{
    public class DeleteSoftHandler : IRequestHandler<DeleteSoft, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public DeleteSoftHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(DeleteSoft request, CancellationToken cancellationToken)
        {
            Pet pet = await this.unitOfWorkRepo.PetRepository.GetByIdAsync(request.Id);

            if (!pet?.IsDeleted ?? false)
            {
                pet!.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException($"The ${nameof(Pet)} with Id ${request.Id} is already deleted");
            }

            await this.unitOfWorkRepo.SaveAsync();

            return pet;
        }
    }
}
