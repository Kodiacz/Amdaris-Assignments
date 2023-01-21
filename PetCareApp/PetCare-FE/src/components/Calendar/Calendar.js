/* eslint-disable no-unused-vars */
import "./Calendar.css"
import { useEffect, useState } from "react";
import CheckIcon from '@mui/icons-material/Check';
import BlockIcon from '@mui/icons-material/Block';
import { PickersDay } from "@mui/x-date-pickers";
import { Badge, TextField } from "@mui/material";
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { StaticDatePicker } from '@mui/x-date-pickers/StaticDatePicker';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';

const Calendar = ({
  availableDays = [],
}) => {
  const [highlightedDays, setHighlightedDays] = useState([]);
  const [value, setValue] = useState(new Date())
  const monthShortNames = [
    "Jan", "Feb", "Mar", "Apr", "May", "Jun",
    "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
  ];

  const currentMonth = new Date().toLocaleDateString().split("/")[0];
  const currentDay = new Date().toLocaleDateString().split("/")[1];
  const currentYear = new Date().toLocaleDateString().split("/")[2];

  useEffect(() => {
    setHighlightedDays(() => [...availableDays])
  }, [availableDays])

  const clicked = (date) => {

  }

  return (
    <div className="calendar">
      <LocalizationProvider dateAdapter={AdapterDayjs}>
        <StaticDatePicker
          orientation="portrait"
          label="Week picker"
          value={value}
          onChange={(newValue) => {
            setValue(() => newValue);
          }}
          renderInput={(params) => <TextField {...params} />}
          inputFormat="MM/DD/YYYY"
          views={["month", "day"]}
          showDaysOutsideCurrentMonth
          onAccept={(value) => clicked(value)}
          renderDay={(day, _value, DayComponentProps) => {
            const dayOfCalendar = day.date();
            const monthOfCalander = Number(JSON.stringify(day.$d).slice(6, 8))
            const yearOfCalender = Number(JSON.stringify(day.$d).slice(8, 10))
            console.log(yearOfCalender)

            const isBeforeCurrentDay = findIfDayIsBeforeCurrentDay();

            function findIfDayIsBeforeCurrentDay() {
              let value = '';
              if ( currentMonth === monthOfCalander) {
                if ( currentDay <= day.date()) {
                  return true;
                }
              } else if (new Date().toLocaleDateString().split("/")[0] < monthOfCalander) {
                return true;
              } else {
                return false
              }
            };

            const isSelected = highlightedDays.find(x => {
              return x.date === day.date() && x.month === monthOfCalander
            })

            return (
              <Badge
                key={day.toString()}
                overlap="circular"
                badgeContent={
                  isSelected
                    ? <CheckIcon color=
                      {isBeforeCurrentDay
                        ? "disabled"
                        : "success"
                      } />
                    : <BlockIcon color=
                      {isBeforeCurrentDay
                        ? "disabled"
                        : "warning"} />
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