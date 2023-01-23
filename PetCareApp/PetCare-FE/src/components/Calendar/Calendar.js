/* eslint-disable react-hooks/exhaustive-deps */
/* eslint-disable no-unused-vars */
import "./Calendar.css"
import { useCallback, useEffect, useState } from "react";
import CheckIcon from '@mui/icons-material/Check';
import BlockIcon from '@mui/icons-material/Block';
import { PickersDay } from "@mui/x-date-pickers";
import { Badge, TextField } from "@mui/material";
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { StaticDatePicker } from '@mui/x-date-pickers/StaticDatePicker';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';

const Calendar = ({
  availableDays = [],
  setNewSchedule,
  setAlertState,
}) => {
  const [highlightedDays, setHighlightedDays] = useState([]);
  const [value, setValue] = useState(new Date())
  var currentMonthAvailableDays = [];
  
  const currentMonth = Number(new Date().toLocaleDateString().split("/")[0]);
  const currentDay = Number(new Date().toLocaleDateString().split("/")[1]);
  const currentYear = Number(new Date().toLocaleDateString().split("/")[2]);

  let newSchedule = {};
  useEffect(() => {
    setHighlightedDays(() => [...availableDays])
  }, [availableDays])


  const clicked = date => {
    const clickedDayOfCalendar = date.$D;
    const clickedMonthOfCalander = Number(JSON.stringify(date.$d).slice(6, 8))
    const clickedYearOfCalender = Number(JSON.stringify(date.$d).slice(1, 5))
    
    if (currentMonthAvailableDays.includes(date.$D)) {
      const result = availableDays.find(
        x => x.date === clickedDayOfCalendar &&
          x.month === clickedMonthOfCalander)

      newSchedule = {
        id: result.scheduleId,
        date: new Date(`${clickedMonthOfCalander}/${clickedDayOfCalendar}/${clickedYearOfCalender} EDT`),
        isAvailable: false,
        doctorId: result.doctorId,
        fullName: result.fullName,
      }
      console.log(newSchedule)
      setNewSchedule(newSchedule)
    } else {
      setAlertState(state => {
        return {
          openValue: true,
          severityValue: 'error',
          titleValue: 'You can\'t make an appointment for this date',
          titleType: 'Error',
        }
      })
    }
  }
  // }, [setNewSchedule])

  return (
    <div className="calendar">
      <LocalizationProvider dateAdapter={AdapterDayjs}>
        <StaticDatePicker
          orientation="portrait"
          label="Week picker"
          value={value}
          onChange={(newValue) => {
            setValue(newValue);
          }}
          renderInput={(params) => <TextField {...params} />}
          inputFormat="MM/DD/YYYY"
          views={["month", "day"]}
          showDaysOutsideCurrentMonth
          onAccept={(value) => clicked(value)}
          renderDay={(day, _value, DayComponentProps) => {
            const dayOfCalendar = day.date();
            const monthOfCalander = Number(JSON.stringify(day.$d).slice(6, 8))
            const yearOfCalender = Number(JSON.stringify(day.$d).slice(1, 5))

            const isBeforeCurrentDay = findIfDayIsBeforeCurrentDay();

            function findIfDayIsBeforeCurrentDay() {
              let value = false;

              if (yearOfCalender === currentYear) {
                if (monthOfCalander >= currentMonth) {
                  if (dayOfCalendar >= currentDay) {
                    value = true;
                  } else {
                    if (monthOfCalander > currentMonth) {
                      value = true;
                    } else {
                      value = false;
                    }
                  }
                }
              }

              return value;
            };
            
            const isSelected = highlightedDays.find(x => x.date === dayOfCalendar && x.month === monthOfCalander)

            if (isSelected?.isAvailable && isBeforeCurrentDay && currentMonthAvailableDays.indexOf(dayOfCalendar) === -1) {
              currentMonthAvailableDays.push(dayOfCalendar)
            }

            return (
              <Badge
                key={day.toString()}
                overlap="circular"
                badgeContent={
                  isSelected?.isAvailable
                    ? <CheckIcon color=
                      {
                        isBeforeCurrentDay
                          ? "success"
                          : "disabled"
                      } />
                    : <BlockIcon color=
                      {
                        isBeforeCurrentDay
                          ? "warning"
                          : "disabled"
                      }
                    />
                }
              >
                <PickersDay {...DayComponentProps} />
              </Badge>
            );
          }}
        />
      </LocalizationProvider>
    </div>
  )
}

export default Calendar;