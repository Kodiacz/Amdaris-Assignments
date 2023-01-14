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
  availableDays
}) => {
  const [highlightedDays, setHighlightedDays] = useState([]);
  const [value, setValue] = useState(new Date())
  
  useEffect(() => {
    setHighlightedDays(() => [...availableDays])
  }, [availableDays])
  
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
            const isBeforeCurrentDay = 
            day.date() < new Date().toLocaleDateString().split("/")[1];
            const isSelected = 
              highlightedDays.indexOf(day.date()) >= 0;

            return (
              <Badge
                key={day.toString()}
                overlap="circular"
                badgeContent={isSelected ? <CheckIcon color={isBeforeCurrentDay ? "disabled" : "success"}/> : <BlockIcon color={isBeforeCurrentDay ? "disabled" : "warning"} />}
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