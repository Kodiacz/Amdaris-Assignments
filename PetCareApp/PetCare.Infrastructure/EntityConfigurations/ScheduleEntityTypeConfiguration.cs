using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCare.Domain.Entities;
using System.Collections.Generic;

namespace PetCare.Infrastructure.EntityConfigurations
{
    public class ScheduleEntityTypeConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder
                .HasData(CreatSchedule());

            builder
                .HasOne(ds => ds.Doctor)
                .WithMany(ds => ds.Schedule);
        }

        private List<Schedule> CreatSchedule()
        {
            List<Schedule> schedules = new();

            DateTime todaysDate = DateTime.UtcNow;
            int year = DateTime.UtcNow.Year;
            int month = DateTime.UtcNow.Month;

            int numberOfDaysForCurrentMonth =
                DateTime.DaysInMonth(year, month) - todaysDate.Day;

            Random random = new Random();
            int itForScheduleEntity = 1;

            for (int i = 1; i <= 6; i++)
            {
                for (int k = 0; k <= numberOfDaysForCurrentMonth; k++)
                {
                    int randomNumber = random.Next(0, 11);

                    Schedule scheduleEntity = new();
                    scheduleEntity.Id = itForScheduleEntity++;
                    scheduleEntity.Date = todaysDate;
                    scheduleEntity.Date = todaysDate.Date.AddDays(k);
                    scheduleEntity.IsAvailable = randomNumber >= 5 ? true : false;
                    scheduleEntity.DoctorId = i;

                    schedules.Add(scheduleEntity);
                }
            }

            return schedules;
        }
    }
}
