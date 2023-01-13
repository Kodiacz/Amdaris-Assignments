import { useState } from "react";
import CheckIcon from '@mui/icons-material/Check';
import { PickersDay } from "@mui/x-date-pickers";
import { avatarClasses, Badge, TextField } from "@mui/material";
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { StaticDatePicker } from '@mui/x-date-pickers/StaticDatePicker';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';

const Calendar = () => {
  const [value, setValue] = useState(new Date())
  const [highlightedDays, setHighlightedDays] = useState([1, 2, 15]);

  const clicked = (date) => {
    console.log(date.date())
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
            const isSelected =
              !DayComponentProps.outsideCurrentMonth &&
              highlightedDays.indexOf(day.date()) >= 0;
  
            return (
              <Badge
                key={day.toString()}
                overlap="circular"
                badgeContent={isSelected ? <CheckIcon /> : undefined}
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