global using Moq;
global using MediatR;
global using NUnit.Framework;
global using System.Threading;
global using PetClinic.Interfaces;
global using PetClinic.Infrastructure;
global using PetClinic.Domain.Entities;
global using Microsoft.EntityFrameworkCore;
global using PetClinic.Application.Exceptions;
global using PetClinic.Application.Interfaces;
global using PetClinic.Infrastructure.Repository;

global using GetOwners = PetClinic.Application.Owners.Queries.Get;
global using CreateOwners = PetClinic.Application.Owners.Commands.Create;
global using DeleteOwners = PetClinic.Application.Owners.Commands.Delete;
global using UpdateOwners = PetClinic.Application.Owners.Commands.Update;

global using CreateDoctors = PetClinic.Application.Doctors.Commands.Create;
global using UpdateDoctors = PetClinic.Application.Doctors.Commands.Update;
global using DeleteDoctors = PetClinic.Application.Doctors.Commands.Delete;
global using GetDoctors = PetClinic.Application.Doctors.Queries.Get;

global using GetPets = PetClinic.Application.Pets.Queries.Get;
global using CreatePets = PetClinic.Application.Pets.Commands.Create;
global using DeletePets = PetClinic.Application.Pets.Commands.Delete;
global using UpdatePets = PetClinic.Application.Pets.Commands.Update;

global using GetRecepitionists = PetClinic.Application.Receptionists.Queries.Get;
global using CreateRecepitionists = PetClinic.Application.Receptionists.Commands.Create;
global using DeleteRecepitionists = PetClinic.Application.Receptionists.Commands.Delete;
global using UpdateRecepitionists = PetClinic.Application.Receptionists.Commands.Update;
