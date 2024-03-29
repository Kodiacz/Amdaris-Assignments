﻿namespace PetCare.Api.Dtos.AppointmentDtos
{
    public class GetAppointmentDto
    {
        public DateTime DateOfAppointment { get; set; }

        public string ReasonForAppointment { get; set; } = null!;

        public string PetName { get; set; } = null!;

        public string DoctorFullName { get; set; } = null!;

        public int OwnerId { get; set; }

        public string OwnerFullName { get; set; } = null!;
    }
}
