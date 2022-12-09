global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Http;

global using AutoMapper;

global using PetClinic.Domain.Entities;

// For DoctorController
global using PetClinic.Api.Dtos.DoctorDtos;
global using PetClinic.Application.Doctors.Queries.Get;
global using PetClinic.Application.Doctors.Commands.Create;
global using PetClinic.Application.Doctors.Commands.Update;
global using static PetClinic.Infrastructure.Common.DatabaseConstants.DoctorConstants;

//For OwnerController
global using PetClinic.Api.Dtos.OwnerDtos;
global using PetClinic.Application.Owners.Queries;
global using PetClinic.Application.Owners.Commands.Create;
global using PetClinic.Application.Owners.Commands.Delete;
global using PetClinic.Application.Owners.Commands.Update;

//For PetController

//For ReceptionistController