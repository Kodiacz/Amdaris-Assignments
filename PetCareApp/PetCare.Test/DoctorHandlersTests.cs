namespace PetCare.Test
{
    using CreateDoctors;
    using UpdateDoctors;
    using DeleteDoctors;
    using GetDoctors;

    public class DoctorHandlersTests
    {
        private Mock<IUnitOfWork> mockUnitOfWork;
        private Mock<IDoctorRepository> mockDoctorRepository;

        [SetUp]
        public void Setup()
        {
            mockUnitOfWork = new();
            mockDoctorRepository = new();
        }

        [Test]
        public async Task Create_Handler_Should_Return_Doctor_Object()
        {
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            CreateDoctor command = new CreateDoctor()
            {
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Doctor",
                StartedJobDate = DateTime.Now,
            };

            var handler = new CreateDoctorHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result, Is.TypeOf(typeof(Doctor)));
            Assert.That(result.FirstName, Is.EqualTo("Pesho"));
        }

        [Test]
        public async Task DeleteSoft_Handler_Should_Set_IsDelete_To_True()
        {
            Doctor ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Doctor",
                StartedJobDate = DateTime.Now,
            };

            mockDoctorRepository.Setup(or => or.GetByIdAsync(1, false)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Doctor result = await handler.Handle(command, default);

            Assert.That(result.IsDeleted, Is.EqualTo(true));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Throw_AlreadyDeletedException()
        {
            Doctor ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Doctor",
                StartedJobDate = DateTime.Now,
                IsDeleted = true,
            };

            mockDoctorRepository.Setup(or => or.GetByIdAsync(1, false)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
        }

        [Test]
        public void DeleteSoft_Handler_Should_Not_Call_SaveAsyncMethod()
        {
            Doctor ownerEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Doctor",
                StartedJobDate = DateTime.Now,
                IsDeleted = true,
            };

            mockDoctorRepository.Setup(or => or.GetByIdAsync(1, false)).ReturnsAsync(ownerEntity);
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            DeleteSoft command = new DeleteSoft() { Id = ownerEntity.Id };
            DeleteSoftHandler handler = new(mockUnitOfWork.Object);

            Assert.ThrowsAsync<AlreadyDeletedException>(() => handler.Handle(command, default));
            mockUnitOfWork.Verify(x => x.SaveAsync(), Times.Never());
        }

        [Test]
        public async Task UpdateHandler_Should_Return_Updated_Doctor()
        {
            Doctor oldEntity = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Doctor",
                StartedJobDate = DateTime.Now,
                IsDeleted = false,
            };

            mockDoctorRepository.Setup(or => or.Update(oldEntity));
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            UpdateDoctor command = new()
            {
                Id = 1,
                FirstName = "PeshoUpdated",
                LastName = "MeshoUpdated",
                Age = 42,
                Phonenumber = "0893399284Updated",
            };

            UpdateDoctorHandler handler = new(mockUnitOfWork.Object);

            Doctor updatedEntity = await handler.Handle(command, default);

            Assert.That(updatedEntity.FirstName, Is.EqualTo("PeshoUpdated"));
            Assert.That(updatedEntity.LastName, Is.EqualTo("MeshoUpdated"));
            Assert.That(updatedEntity.Age, Is.EqualTo(42));
            Assert.That(updatedEntity.Phonenumber, Is.EqualTo("0893399284Updated"));
            Assert.That(updatedEntity.IsDeleted, Is.EqualTo(false));
        }

        [Test]
        public async Task GetAllDoctorsHandlers_Should_Return_The_Correct_Count_Of_The_Collection()
        {
            List<Doctor> owners = new()
            {
                new Doctor
                {
                    Id = 1,
                    FirstName = "Pesho",
                    LastName = "Mesho",
                    Age = 45,
                    Phonenumber = "0893399284",
                    JobDescription = "Doctor",
                    StartedJobDate = DateTime.Now,
                    IsDeleted = true,
                },
                new Doctor()
                {
                    Id = 2,
                    Age = 2,
                    FirstName = "gosho",
                    LastName = "mosho",
                    Phonenumber = "0899235011",
                },
               new Doctor()
                {
                    Id = 3,
                    Age = 3,
                    FirstName = "dimo",
                    LastName = "mimo",
                    Phonenumber = "0899535561",
                },
            };

            mockDoctorRepository.Setup(or => or.GetAllAsync()).ReturnsAsync(owners);
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            GetAllDoctors command = new();
            GetAllDoctorsHandler handler = new(mockUnitOfWork.Object);

            List<Doctor> entities = await handler.Handle(command, default);
            Assert.That(entities.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GetDoctorById_Handler_Should_Return_Doctor_Object()
        {
            Doctor owner = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Doctor",
                StartedJobDate = DateTime.Now,
                IsDeleted = false,
            };

            mockDoctorRepository.Setup(or => or.GetByIdAsync(1, false)).ReturnsAsync(owner);
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            GetDoctorById command = new() { Id = 1 };

            var handler = new GetDoctorByIdHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result.FirstName, Is.EqualTo("Pesho"));
        }

        [Test]
        public void GetDoctorById_Handler_Should_Throw_ArgumentNullException()
        {
            Doctor owner = new()
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284",
                JobDescription = "Doctor",
                StartedJobDate = DateTime.Now,
                IsDeleted = false,
            };

            mockDoctorRepository.Setup(or => or.GetByIdAsync(1, false)).ReturnsAsync(owner);
            mockUnitOfWork.Setup(x => x.DoctorRepository).Returns(mockDoctorRepository.Object);

            GetDoctorById command = new() { Id = 5 };

            var handler = new GetDoctorByIdHandler(mockUnitOfWork.Object);

            Assert.ThrowsAsync<ArgumentNullException>(() => handler.Handle(command, default));
        }
    }
}
