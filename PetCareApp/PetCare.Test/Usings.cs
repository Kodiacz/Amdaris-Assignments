global using Moq;
global using MediatR;
global using NUnit.Framework;
global using System.Threading;
global using PetCare.Interfaces;
global using PetCare.Infrastructure;
global using PetCare.Domain.Entities;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Infrastructure;
global using PetCare.Application.Exceptions;
global using PetCare.Application.Interfaces;
global using PetCare.Infrastructure.Repository;

global using GetOwners = PetCare.Application.Owners.Queries.Get;
global using CreateOwners = PetCare.Application.Owners.Commands.Create;
global using DeleteOwners = PetCare.Application.Owners.Commands.Delete;
global using UpdateOwners = PetCare.Application.Owners.Commands.Update;

global using CreateDoctors = PetCare.Application.Doctors.Commands.Create;
global using UpdateDoctors = PetCare.Application.Doctors.Commands.Update;
global using DeleteDoctors = PetCare.Application.Doctors.Commands.Delete;
global using GetDoctors = PetCare.Application.Doctors.Queries.Get;

global using GetPets = PetCare.Application.Pets.Queries.Get;
global using CreatePets = PetCare.Application.Pets.Commands.Create;
global using DeletePets = PetCare.Application.Pets.Commands.Delete;
global using UpdatePets = PetCare.Application.Pets.Commands.Update;

global using GetRecepitionists = PetCare.Application.Receptionists.Queries.Get;
global using CreateRecepitionists = PetCare.Application.Receptionists.Commands.Create;
global using DeleteRecepitionists = PetCare.Application.Receptionists.Commands.Delete;
global using UpdateRecepitionists = PetCare.Application.Receptionists.Commands.Update;
