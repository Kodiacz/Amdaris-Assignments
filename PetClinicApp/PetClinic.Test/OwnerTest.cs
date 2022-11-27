using PetClinic.Application.Contracts;
using PetClinic.Domain.Entities;
using PetClinic.Infrastructure;

namespace PetClinic.Test
{
    [TestFixture]
    public class OwnerTest
    {
        IOwnerRepository ownerRepo;

        [SetUp]
        public void Setup()
        {
            ownerRepo = new InMemoryOwnerRepository();
        }

        [Test]
        public void CreateOwnerTest()
        {
            //Arrange

            //Act


            //Assert
        }
    }
}