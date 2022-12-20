namespace PetCare.Test
{
    using GetPets;
    using CreatePets;
    using DeletePets;
    using UpdatePets;

    public class PetHandlersTests
    {
        private Mock<IUnitOfWork> mockUnitOfWork;
        private Mock<IPetRepository> mockPetRepository;
        private Mock<IOwnerRepository> mockOwnerRepository;


        [SetUp]
        public void Setup()
        {
            mockUnitOfWork = new();
            mockPetRepository = new();
            mockOwnerRepository = new();
        }

        [Test]
        public async Task Create_Handler_Should_Return_Pet_Object()
        {
            Owner pet = new Owner()
            {
                Id = 1,
            };

            mockOwnerRepository.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(pet);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            CreatePet command = new CreatePet()
            {
                Name = "Roco",
                Age = 5,
                Breed = "chao chao",
                Type = "Dog",
                OwnerId = 1,
            };

            var handler = new CreatePetHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result, Is.TypeOf(typeof(Pet)));
            Assert.That(result.Name, Is.EqualTo("Roco"));
        }

        [Test]
        public async Task DeleteSoft_Handler_Should_Set_IsDelete_To_True()
        {
            Pet petEntity = new()
            {
                Id = 1,
                Name = "Roco",
                Age = 5,
                Breed = "chao chao",
                Type = "Dog",
                OwnerId = 1,
            };

            mockPetRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(petEntity);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = petEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Pet result = await handler.Handle(command, default);

            Assert.That(result.IsDeleted, Is.EqualTo(true));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Throw_AlreadyDeletedException()
        {
            Pet petEntity = new()
            {
                Id = 1,
                Name = "Roco",
                Age = 5,
                Breed = "chao chao",
                Type = "Dog",
                OwnerId = 1,
                IsDeleted = true,
            };

            mockPetRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(petEntity);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = petEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Not_Call_SaveAsyncMethod()
        {
            Pet petEntity = new()
            {
                Id = 1,
                Name = "Roco",
                Age = 5,
                Breed = "chao chao",
                Type = "Dog",
                OwnerId = 1,
                IsDeleted = true,
            };

            mockPetRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(petEntity);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = petEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
            mockUnitOfWork.Verify(x => x.SaveAsync(), Times.Never());
        }

        [Test]
        public async Task UpdateHandler_Should_Return_Updated_Pet()
        {
            Pet oldEntity = new()
            {
                Id = 1,
                Name = "Roco",
                Age = 5,
                Breed = "chao chao",
                Type = "Dog",
                OwnerId = 1,
                IsDeleted = false,
            };

            mockPetRepository.Setup(or => or.UpdateAsync(oldEntity));
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            UpdatePet command = new()
            {
                Id = 1,
                Name = "RocoUpdated",
                Age = 6,
                Breed = "chao chaoUpdated",
                Type = "DogUpdated",
                OwnerId = 1,
            };

            UpdatePetHandler handler = new(mockUnitOfWork.Object);

            Pet updatedEntity = await handler.Handle(command, default);

            Assert.That(updatedEntity.Name, Is.EqualTo("RocoUpdated"));
            Assert.That(updatedEntity.Breed, Is.EqualTo("chao chaoUpdated"));
            Assert.That(updatedEntity.Age, Is.EqualTo(6));
            Assert.That(updatedEntity.Type, Is.EqualTo("DogUpdated"));
            Assert.That(updatedEntity.IsDeleted, Is.EqualTo(false));
        }

        [Test]
        public async Task GetAllPetsHandlers_Should_Return_The_Correct_Count_Of_The_Collection()
        {
            List<Pet> pets = new()
            {
                new Pet
                {
                    Id = 1,
                    Name = "RocoUpdated",
                    Age = 6,
                    Breed = "chao chaoUpdated",
                    Type = "DogUpdated",
                    OwnerId = 1,
                    IsDeleted = false,
                },
                new Pet()
                {
                    Id = 2,
                    Name = "RocoUpdated",
                    Age = 6,
                    Breed = "chao chaoUpdated",
                    Type = "DogUpdated",
                    OwnerId = 1,
                },
               new Pet()
                {
                    Id = 3,
                    Name = "RocoUpdated",
                    Age = 6,
                    Breed = "chao chaoUpdated",
                    Type = "DogUpdated",
                    OwnerId = 1,
                },
            };

            mockPetRepository.Setup(or => or.GetAllAsync()).ReturnsAsync(pets);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            GetAllPets command = new();
            GetAllPetsHandler handler = new(mockUnitOfWork.Object);

            List<Pet> entities = await handler.Handle(command, default);
            Assert.That(entities.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GetPetById_Handler_Should_Return_Pet_Object()
        {
            Pet pet = new()
            {
                Id = 1,
                Name = "Roco",
                Age = 5,
                Breed = "chao chao",
                Type = "Dog",
                OwnerId = 1,
                IsDeleted = false,
            };

            mockPetRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(pet);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            GetPetById command = new() { Id = 1 };

            var handler = new GetPetByIdHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Roco"));
        }

        [Test]
        public void GetPetById_Handler_Should_Throw_ArgumentNullException()
        {
            Pet pet = new()
            {
                Id = 1,

                IsDeleted = false,
            };

            mockPetRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(pet);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            GetPetById command = new() { Id = 5 };

            var handler = new GetPetByIdHandler(mockUnitOfWork.Object);

            Assert.ThrowsAsync<ArgumentNullException>(() => handler.Handle(command, default));
        }
    }
}
