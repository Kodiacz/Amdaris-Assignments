global using System.Net;
global using Microsoft.AspNetCore.Cors;
global using System.Security.Cryptography;
global using SystemJson = System.Text.Json;
global using System.Text.Json.Serialization;
global using System.ComponentModel.DataAnnotations;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Http;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.AspNetCore.JsonPatch;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Authentication.JwtBearer;

global using MediatR;
global using Microsoft.Identity.Web;
global using NewtonJson = Newtonsoft.Json;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Authorization;

global using AutoMapper;
global using PetCare.Api.Models;
global using PetCare.Interfaces;
global using PetCare.Api.Filters;
global using PetCare.Infrastructure;
global using PetCare.Api.Extensions;
global using PetCare.Domain.Entities;
global using PetCare.Api.Dtos.UserDtos;
global using PetCare.Application.Models;
global using PetCare.Application.Interfaces;
global using PetCare.Application.Exceptions;
global using PetCare.Api.Dtos.AppointmentDtos;
global using PetCare.Infrastructure.Repository;
global using static PetCare.Api.Common.Constants;
global using PetCare.Application.Authentication.Commands;
global using static PetCare.Api.Controllers.FileUploadController;

//For DoctorController
global using PetCare.Api.Dtos.DoctorDtos;
global using PetCare.Api.Dtos.ScheduleDtos;
global using GetDoctor = PetCare.Application.Doctors.Queries.Get;
global using CreateDoctor = PetCare.Application.Doctors.Commands.Create;
global using UpdateDoctor = PetCare.Application.Doctors.Commands.Update;
global using DeleteDoctor = PetCare.Application.Doctors.Commands.Delete;
global using static PetCare.Infrastructure.Common.DatabaseConstants.DoctorConstants;
global using UpdatePartialDoctor = PetCare.Application.Doctors.Commands.PartialUpdate;

//For OwnerController
global using PetCare.Api.Dtos.OwnerDtos;
global using GetOwner = PetCare.Application.Owners.Queries.Get;
global using CreateOwner = PetCare.Application.Owners.Commands.Create;
global using UpdateOwner = PetCare.Application.Owners.Commands.Update;
global using DeleteOwner = PetCare.Application.Owners.Commands.Delete;
global using static PetCare.Infrastructure.Common.DatabaseConstants.OwnerConstants;
global using PartialUpdateOwner = PetCare.Application.Owners.Commands.PartialUpdate;

//For PetController
global using PetCare.Api.Dtos.PetDtos;
global using GetPet = PetCare.Application.Pets.Queries.Get;
global using CreatePet = PetCare.Application.Pets.Commands.Create;
global using UpdatePet = PetCare.Application.Pets.Commands.Update;
global using DeletePet = PetCare.Application.Pets.Commands.Delete;
global using UpdatePartialPet = PetCare.Application.Pets.Commands.PartialUpdate;
global using static PetCare.Infrastructure.Common.DatabaseConstants.PetConstnats;
//For ReceptionistController
global using PetCare.Api.Dtos.RecceptionistDtos;
global using GetReceptionist = PetCare.Application.Receptionists.Queries.Get;
global using CreateReceptionist = PetCare.Application.Receptionists.Commands.Create;
global using UpdateReceptionist = PetCare.Application.Receptionists.Commands.Update;
global using DeleteReceptionist = PetCare.Application.Receptionists.Commands.Delete;
global using static PetCare.Infrastructure.Common.DatabaseConstants.ReceptionistConstants;
global using UpdatePartialReceptionist = PetCare.Application.Receptionists.Commands.PartialUpdate;

//global using PetCare.Api.Dtos.AppointmentsDtos;
//global using GetAppointments = PetCare.Application.Appointments.Queries.Get;
global using CreateAppointments = PetCare.Application.Appointments.Commands.Create;
//global using UpdateAppointments = PetCare.Application.Appointments.Commands.Update;
//global using DeleteAppointments = PetCare.Application.Appointments.Commands.Delete;
//global using static PetCare.Infrastructure.Common.DatabaseConstants.ReceptionistConstants;
//global using UpdatePartialAppointments = PetCare.Application.Appointments.Commands.PartialUpdate;


