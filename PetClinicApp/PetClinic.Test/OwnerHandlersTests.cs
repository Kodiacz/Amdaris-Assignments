namespace PetClinic.Test
{
    [TestFixture]
    public class OwnerCreateHandlerTest
    {
        private Mock<IUnitOfWork> mockUnitOfWork;
        private Mock<IOwnerRepository> mockOwnerRepository;

        [SetUp]
        public void Setup()
        {
            mockUnitOfWork = new();
            mockOwnerRepository = new();

        }

        [Test]
        public async Task Create_Handler_Should_Return_Owner_Object()
        {
            mockUnitOfWork.Setup(x => x.OwnerRepository).Returns(mockOwnerRepository.Object);

            CreateOwner command = new CreateOwner()
            {
                FirstName = "Pesho",
                LastName = "Mesho",
                Age = 45,
                Phonenumber = "0893399284"
            };

            var handler = new CreateOwnerHandler(mockUnitOfWork.Object);

            var result = await handler.Handle(command, default);

            Assert.IsNotNull(result);
            Assert.That(result, Is.TypeOf(typeof(Owner)));
            Assert.That(result.FirstName, Is.EqualTo("Pesho"));
        }
    }
}
