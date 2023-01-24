using PetCare.Application.Pets.Commands.Update;

namespace PetCare.Application.Pets.Commands.PartialUpdate
{
    public class PartialUpdatePetHendler : IRequestHandler<PartialUpdatePet, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public PartialUpdatePetHendler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(PartialUpdatePet request, CancellationToken cancellationToken)
        {
            Pet pet = new Pet
            {
                Id = request.Id,
                Name = request.Name,
                Type = request.Type,
                Age = request.Age,
                Breed = request.Breed,
                OwnerId = request.OwnerId,
                DoctorId = request.DoctorId,
                ImageFilePath = request.ImageFilePath,
            };

            await this.unitOfWorkRepo.PetRepository.UpdateAsync(pet);
            await this.unitOfWorkRepo.SaveAsync();

            return pet;
        }
    }
}
