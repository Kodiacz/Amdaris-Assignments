namespace PetCare.Test
{
    using GetRecepitionists;
    using CreateRecepitionists;
    using DeleteRecepitionists;
    using UpdateRecepitionists;

    public class ReceptionistHandlersTests
    {
        private Mock<IUnitOfWork> mockUnitOfWork;
        private Mock<IReceptionistRepository> mockReceptionistRepository;

        [SetUp]
        public void Setup()
        {
            mockUnitOfWork = new();
            mockReceptionistRepository = new();
        }

        [Test]
        public async Task Create_Handler_Should_Return_Receptionist_Object()
        {
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            CreateReceptionist command = new CreateReceptionist()
            {
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Receptionist",
                StartedJobDate = DateTime.Now, 
            };

            var handler = new CreateReceptionistHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result, Is.TypeOf(typeof(Receptionist)));
            Assert.That(result.FirstName, Is.EqualTo("Pesho"));
        }

        [Test]
        public async Task DeleteSoft_Handler_Should_Set_IsDelete_To_True()
        {
            Receptionist ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Receptionist",
                StartedJobDate = DateTime.Now, 
            };

            mockReceptionistRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Receptionist result = await handler.Handle(command, default);

            Assert.That(result.IsDeleted, Is.EqualTo(true));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Throw_AlreadyDeletedException()
        {
            Receptionist ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Receptionist",
                StartedJobDate = DateTime.Now, 
                IsDeleted = true,
            };

            mockReceptionistRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Not_Call_SaveAsyncMethod()
        {
            Receptionist ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Receptionist",
                StartedJobDate = DateTime.Now, 
                IsDeleted = true,
            };

            mockReceptionistRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
            mockUnitOfWork.Verify(x => x.SaveAsync(), Times.Never());
        }

        [Test]
        public async Task UpdateHandler_Should_Return_Updated_Receptionist()
        {
            Receptionist oldEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Receptionist",
                StartedJobDate = DateTime.Now, 
                IsDeleted = false,
            };

            mockReceptionistRepository.Setup(or => or.UpdateAsync(oldEntity));
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            UpdateReceptionist command = new()
            {
                Id = 1,
                FirstName = "PeshoUpdated",
                LastName = "MeshoUpdated",
                Age = 42,
                Phonenumber = "0893399284Updated",
            };

            UpdateReceptionistHandler handler = new(mockUnitOfWork.Object);

            Receptionist updatedEntity = await handler.Handle(command, default);

            Assert.That(updatedEntity.FirstName, Is.EqualTo("PeshoUpdated"));
            Assert.That(updatedEntity.LastName, Is.EqualTo("MeshoUpdated"));
            Assert.That(updatedEntity.Age, Is.EqualTo(42));
            Assert.That(updatedEntity.Phonenumber, Is.EqualTo("0893399284Updated"));
            Assert.That(updatedEntity.IsDeleted, Is.EqualTo(false));
        }

        [Test]
        public async Task GetAllReceptionistsHandlers_Should_Return_The_Correct_Count_Of_The_Collection()
        {
            List<Receptionist> owners = new()
            {
                new Receptionist
                {
                    Id = 1,
                    FirstName = "Pesho",
                    LastName = "Mesho",
                    Age = 45,
                    Phonenumber = "0893399284",
                    JobDescription = "Receptionist",
                    StartedJobDate = DateTime.Now, 
                    IsDeleted = true,
                },
                new Receptionist()
                {
                    Id = 2,
                    Age = 2,
                    FirstName = "gosho",
                    LastName = "mosho",
                    Phonenumber = "0899235011",
                },
               new Receptionist()
                {
                    Id = 3,
                    Age = 3,
                    FirstName = "dimo",
                    LastName = "mimo",
                    Phonenumber = "0899535561",
                },
            };

            mockReceptionistRepository.Setup(or => or.GetAllAsync()).ReturnsAsync(owners);
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            GetAllReceptionists command = new();
            GetAllReceptionistsHandler handler = new(mockUnitOfWork.Object);

            List<Receptionist> entities = await handler.Handle(command, default);
            Assert.That(entities.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GetReceptionistById_Handler_Should_Return_Receptionist_Object()
        {
            Receptionist owner = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Receptionist",
                StartedJobDate = DateTime.Now, 
                IsDeleted = false,
            };

            mockReceptionistRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(owner);
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            GetByIdReceptionist command = new() { Id = 1 };

            var handler = new GetByIdReceptionistHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result.FirstName, Is.EqualTo("Pesho"));
        }

        [Test]
        public void GetReceptionistById_Handler_Should_Throw_ArgumentNullException()
        {
            Receptionist owner = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Receptionist",
                StartedJobDate = DateTime.Now, 
                IsDeleted = false,
            };

            mockReceptionistRepository.Setup(or => or.GetByIdAsync(1)).ReturnsAsync(owner);
            mockUnitOfWork.Setup(x => x.ReceptionistRepository).Returns(mockReceptionistRepository.Object);

            GetByIdReceptionist command = new() { Id = 5 };

            var handler = new GetByIdReceptionistHandler(mockUnitOfWork.Object);

            Assert.ThrowsAsync<ArgumentNullException>(() => handler.Handle(command, default));
        }
    }
}
