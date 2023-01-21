namespace PetCare.Test
{
    using GetOwners;
    using CreateOwners;
    using DeleteOwners;
    using UpdateOwners;
    using System.Linq.Expressions;
using System.Linq;
using Azure.Core;

    [TestFixture]
    public class OwnerHandlersTests
    {
        private Mock<IUnitOfWork> mockUnitOfWork;
        private Mock<IOwnerRepository> mockOwnerRepository;
        private Mock<IPetRepository> mockPetRepository;

        [SetUp]
        public void Setup()
        {
            mockUnitOfWork = new();
            mockOwnerRepository = new();
            mockPetRepository = new();
        }

        [Test]
        public async Task Create_Handler_Should_Return_Owner_Object()
        {
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            CreateOwner command = new CreateOwner()
            {
                FirstName = "Pesho",
                LastName = "Mesho",
                Phonenumber = "0893399284"
            };

            var handler = new CreateOwnerHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result, Is.TypeOf(typeof(Owner)));
            Assert.That(result.FirstName, Is.EqualTo("Pesho"));
        }

        [Test]
        public async Task DeleteSoft_Handler_Should_Set_IsDelete_To_True()
        {
            Owner ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Phonenumber = "0893399284"
            };

            mockOwnerRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Owner result = await handler.Handle(command, default);

            Assert.That(result.IsDeleted, Is.EqualTo(true));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Throw_AlreadyDeletedException()
        {
            Owner ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Phonenumber = "0893399284",
                IsDeleted = true,
            };

            mockOwnerRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Not_Call_SaveAsyncMethod()
        {
            Owner ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Phonenumber = "0893399284",
                IsDeleted = true,
            };

            mockOwnerRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
            mockUnitOfWork.Verify(x => x.SaveAsync(), Times.Never());
        }

        [Test]
        public async Task UpdateHandler_Should_Return_Updated_Owner()
        {
            Owner oldEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                IsDeleted = false,
            };

            mockOwnerRepository.Setup(or => or.UpdateAsync(oldEntity));
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            UpdateOwner command = new()
            {
                Id = 1,
                FirstName = "PeshoUpdated",
                LastName = "MeshoUpdated",
                Phonenumber = "0893399284Updated",
            };

            UpdateOwnerHandler handler = new(mockUnitOfWork.Object);

            Owner updatedEntity = await handler.Handle(command, default);

            Assert.That(updatedEntity.FirstName, Is.EqualTo("PeshoUpdated"));
            Assert.That(updatedEntity.LastName, Is.EqualTo("MeshoUpdated"));
            Assert.That(updatedEntity.Age, Is.EqualTo(42));
            Assert.That(updatedEntity.Phonenumber, Is.EqualTo("0893399284Updated"));
            Assert.That(updatedEntity.IsDeleted, Is.EqualTo(false));
        }

        [Test]
        public async Task GetAllOwnersHandlers_Should_Return_The_Correct_Count_Of_The_Collection()
        {
            List<Owner> owners = new()
            {
                new Owner
                {
                    Id = 1,
                    FirstName = "Pesho",
                    LastName = "Mesho",
                    Age = 45,
                    Phonenumber = "0893399284",
                    IsDeleted = false,
                },
                new Owner()
                {
                    Id = 2,
                    Age = 2,
                    FirstName = "gosho",
                    LastName = "mosho",
                    Phonenumber = "0899235011",
                },
               new Owner()
                {
                    Id = 3,
                    Age = 3,
                    FirstName = "dimo",
                    LastName = "mimo",
                    Phonenumber = "0899535561",
                },
            };

            mockOwnerRepository.Setup(or => or.GetAllAsync()).ReturnsAsync(owners);
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            GetAllOwners command = new();
            GetAllOwnersHandler handler = new(mockUnitOfWork.Object);

            List<Owner> entities = await handler.Handle(command, default);
            Assert.That(entities.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GetOwnerById_Handler_Should_Return_Owner_Object()
        {
            Owner owner = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                IsDeleted = false,
            };

            mockOwnerRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(owner);
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            GetOwnerById command = new() { Id = 1 };

            var handler = new GetOwnerByIdHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result.FirstName, Is.EqualTo("Pesho"));
        }

        [Test]
        public void GetOwnerById_Handler_Should_Throw_ArgumentNullException()
        {
            Owner owner = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                IsDeleted = false,
            };

            mockOwnerRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(owner);
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            GetOwnerById command = new() { Id = 5 };

            var handler = new GetOwnerByIdHandler(mockUnitOfWork.Object);

            Assert.ThrowsAsync<ArgumentNullException>(() => handler.Handle(command, default));
        }

        [Test]
        public async Task GetOwnerPets_Handler_Should_Throw_ArgumrntNullException()
        {
            mockPetRepository.Setup(x => x.GetAllAsync(x => x.OwnerId == 1 && !x.IsDeleted)).ReturnsAsync((List<Pet>)null);
            mockUnitOfWork.Setup(x => x.PetRepository).Returns(mockPetRepository.Object);

            GetAllOwnerPets query = new() { OwnerId = 1 };
            GetAllOwnerPetsHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<ArgumentNullException>(() => handler.Handle(query, default));
        }
    }
}

