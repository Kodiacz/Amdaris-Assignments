using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PetClinic.Application.Contracts;
using PetClinic.Application.Owners.Commands;
using PetClinic.Application.Pets.Commands;
using PetClinic.Domain.Entities;
using PetClinic.Infrastructure;

var diContainer = new ServiceCollection()
    .AddMediatR(typeof(IOwnerRepository))
    .AddScoped<IOwnerRepository, InMemoryOwnerRepository>()
    .AddScoped<IPetRpository, InMemoryPetRepository>()
    .BuildServiceProvider();

var mediator = diContainer.GetRequiredService<IMediator>();

var userId = await mediator.Send(new CreateOwnerCommand()
{
    FirstName = "Pencho",
    LastName = "Mencho",
    Phonenumber = "0899443323",
    Age = 33,
});

//var petId = await mediator.Send(new CreatePetCommand()
//{

//})