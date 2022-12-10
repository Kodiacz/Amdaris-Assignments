global using System.ComponentModel.DataAnnotations;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Http;

global using AutoMapper;
global using MediatR;

global using PetClinic.Domain.Entities;
global using PetClinic.Application.Exceptions;

// For DoctorController
global using PetClinic.Api.Dtos.DoctorDtos;
global using GetDoctor = PetClinic.Application.Doctors.Queries.Get;
global using CreateDoctor = PetClinic.Application.Doctors.Commands.Create;
global using UpdateDoctor = PetClinic.Application.Doctors.Commands.Update;
global using DeleteDoctor = PetClinic.Application.Doctors.Commands.Delete;
global using static PetClinic.Infrastructure.Common.DatabaseConstants.DoctorConstants;

//For OwnerController
global using PetClinic.Api.Dtos.OwnerDtos;
global using GetOwner = PetClinic.Application.Owners.Queries.Get;
global using CreateOwner = PetClinic.Application.Owners.Commands.Create;
global using UpdateOwner = PetClinic.Application.Owners.Commands.Update;
global using DeleteOwner = PetClinic.Application.Owners.Commands.Delete;
global using static PetClinic.Infrastructure.Common.DatabaseConstants.OwnerConstants;

//For PetController
global using PetClinic.Api.Dtos;
global using GetPet = PetClinic.Application.Pets.Queries.Get;
global using CreatePet = PetClinic.Application.Pets.Commands.Create;
global using UpdatePet = PetClinic.Application.Pets.Commands.Update;
global using DeletePet = PetClinic.Application.Pets.Commands.Delete;
global using static PetClinic.Infrastructure.Common.DatabaseConstants.PetConstnats;

//For ReceptionistController
global using PetClinic.Api.Dtos;
global using GetReceptionist = PetClinic.Application.Receptionists.Queries.Get;
global using CreateReceptionist = PetClinic.Application.Receptionists.Commands.Create;
global using UpdateReceptionist = PetClinic.Application.Receptionists.Commands.Update;
global using DeleteReceptionist = PetClinic.Application.Receptionists.Commands.Delete;
global using static PetClinic.Infrastructure.Common.DatabaseConstants.ReceptionistConstants;