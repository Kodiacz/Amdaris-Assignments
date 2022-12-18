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

        //[Test]
        //public async Task GetAllOwnersTest()
        //{
        //    var ownerRepo = new OwnerRepository(contextInMemmory);

        //    unitOfWorkMock.Setup(x => x.OwnerRepository).Returns(ownerRepo);
        //    var unitOfWork = unitOfWorkMock.Object;

        //    var command = new GetAllOwners();

        //    List<Owner> owners = new()
        //    {
        //       new Owner()
        //        {
        //            Id = 1,
        //            Age = 1,
        //            FirstName = "pesho",
        //            LastName = "mesho",
        //            Phonenumber = "0899535231",
        //        },
        //       new Owner()
        //        {
        //            Id = 2,
        //            Age = 2,
        //            FirstName = "gosho",
        //            LastName = "mosho",
        //            Phonenumber = "0899235011",
        //        },
        //       new Owner()
        //        {
        //            Id = 3,
        //            Age = 3,
        //            FirstName = "dimo",
        //            LastName = "mimo",
        //            Phonenumber = "0899535561",
        //        },
        //    };

        //    await unitOfWork.OwnerRepository.AddAsync(owners[0]);
        //    await unitOfWork.OwnerRepository.AddAsync(owners[1]);
        //    await unitOfWork.OwnerRepository.AddAsync(owners[2]);

        //    GetAllOwnersHandler handler = new(unitOfWork);
        //    var ownersEntities = await contextInMemmory.Owners.ToListAsync();
        //    //var ownersEntities = await handler.Handle(command, default);

        //    Assert.That(ownersEntities.Count, Is.EqualTo(3));
        //}

        [TearDown]
        public void TearDown()
        {
            contextInMemmory.Dispose();
        }
    }
}