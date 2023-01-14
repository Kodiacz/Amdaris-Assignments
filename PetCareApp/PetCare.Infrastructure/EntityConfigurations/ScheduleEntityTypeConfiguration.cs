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
			List<Schedule> schedules = new List<Schedule>();

			Random random = new Random();
			int iDForScheduleEntity = 1;

			for (int entityId = 1; entityId <= 6; entityId++)
			{
				for (int month = 1; month <= 4; month++)
				{
					DateTime firstDayOfTheMonth = new DateTime(2023, month, 1);
					int numberOfDaysForCurrentMonth = DateTime.DaysInMonth(2023, month);


					for (int day = 0; day < numberOfDaysForCurrentMonth; day++)
					{
						int randomNumber = random.Next(0, 6);

						Schedule scheduleEntity = new Schedule();
						scheduleEntity.Id = iDForScheduleEntity++;
						scheduleEntity.Date = firstDayOfTheMonth;
						scheduleEntity.Date = firstDayOfTheMonth.Date.AddDays(day);
						scheduleEntity.IsAvailable = randomNumber >= 3 ? true : false;
						scheduleEntity.DoctorId = entityId;

						schedules.Add(scheduleEntity);
					}
				}
			}

			return schedules;
		}
	}
}
