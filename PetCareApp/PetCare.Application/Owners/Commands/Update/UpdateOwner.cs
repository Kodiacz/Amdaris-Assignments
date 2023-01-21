﻿namespace PetCare.Application.Owners.Commands.Update
{
    public class UpdateOwner : IRequest<Owner>
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phonenumber { get; set; } = null!;

        public string? ProfileImageFilePath { get; set; }

    }
}
