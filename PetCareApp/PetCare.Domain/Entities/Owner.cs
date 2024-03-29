﻿namespace PetCare.Domain.Entities
{
    using PetCare.Domain.AbstracClasses;

    public class Owner : Person
    {
        public Owner()
        {
            this.Pets = new HashSet<Pet>();
            this.Appointments = new HashSet<Appointment>();
            this.UsersRoles = new HashSet<UsersRoles>();
        }

        public int Id { get; set; }

        public string? Username { get; set; } = null!;

        public string? Email { get; set; } = null!;

        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public string? ProfileImageFilePath { get; set; }

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public int? ReceptionistId { get; set; }
        public Receptionist? Receptionist { get; set; }

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        public ICollection<UsersRoles> UsersRoles { get; set; }
    }
}
