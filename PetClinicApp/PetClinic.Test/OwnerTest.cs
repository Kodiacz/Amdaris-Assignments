namespace PetClinic.Test
{
    [TestFixture]
    public class OwnerTest
    {
        private Mock<IOwnerRepository> ownerRepositoryMock;
        private Mock<IUnitOfWork> unitOfWorkMock;
        private PetClinicDbContext contextInMemmory;

        [SetUp]
        public void Setup()
        {
            ownerRepositoryMock = new();
            unitOfWorkMock = new();
            var contextOptions = new DbContextOptionsBuilder<PetClinicDbContext>()
                .UseInMemoryDatabase("InMemmoryPetClinicDB")
                .Options;

            contextInMemmory = new PetClinicDbContext(contextOptions);

            contextInMemmory.Database.EnsureDeleted();
            contextInMemmory.Database.EnsureCreated();
        }

        [Test]
        public async Task CreateOwnerSuccessfullyHandlerTest()
        {
            //Arrange
            var ownerRepo = new OwnerRepository(contextInMemmory);

            unitOfWorkMock.Setup(x => x.OwnerRepository).Returns(ownerRepo);
            var unitOfWork = unitOfWorkMock.Object;

            var command = new CreateOwner()
            {
                Age = 1,
                FirstName = "FirstName",
                LastName = "LastName",
                Phonenumber = "0899535011",
            };

            var handler = new CreateOwnerHandler(unitOfWork);

            //Act
            var result = await handler.Handle(command, default);

            //Owner test = await unitOfWork.OwnerRepository.GetByIdAsync(result.Id);
            Owner test = (await contextInMemmory.Owners.FindAsync(result.Id))!;


            //Assert
            Assert.That(test.FirstName, Is.EqualTo("FirstName"));
            Assert.That(test.LastName, Is.EqualTo("LastName"));
            Assert.That(test.Phonenumber, Is.EqualTo("0899535011"));
            Assert.That(test.Age, Is.EqualTo(1));
        }

        [TearDown]
        public void TearDown()
        {
            contextInMemmory.Dispose();
        }
    }
}