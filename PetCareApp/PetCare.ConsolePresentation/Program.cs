using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PetCare.Interfaces;

var diContainer = new ServiceCollection()
    .AddMediatR(typeof(IOwnerRepository))
    .AddMediatR(typeof(IPetRepository))
    .BuildServiceProvider();

var mediator = diContainer.GetRequiredService<IMediator>();

//var userId = await mediator.Send(new CreateOwnerCommand()
//{
//    FirstName = "Stefan",
//    LastName = "Petrov",
//    Phonenumber = "0899443323",
//    Age = 33,
//});

//var petId = await mediator.Send(new CreatePetCommand()
//{
//    Age = 2,
//    Breed = "dog",
//    Name = "Rex",
//    OwnerId = userId,
//});

Console.WriteLine("Completed");