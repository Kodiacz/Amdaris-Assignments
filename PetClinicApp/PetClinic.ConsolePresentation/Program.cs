using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PetClinic.Application;
using PetClinic.Infrastructure;

var diContainer = new ServiceCollection()
    .AddMediatR(typeof(IOwnerRepository))
    .AddScoped<IOwnerRepository, InMemoryOwnerRepository>()
    .BuildServiceProvider();

var mediator = diContainer.GetRequiredService<IMediator>();

