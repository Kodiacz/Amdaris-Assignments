import { avatarClasses, TextField } from "@mui/material";
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { StaticDatePicker } from '@mui/x-date-pickers/StaticDatePicker';
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { useState } from "react";
import "./Calendar.css"

const Calendar = () => {
  const [value, setValue] = useState(new Date())

  const clicked = (date) => {
    console.log(date.date())

    let test = [];

    for (let i = 0; i < 10; i++) {
      let random = Math.random() * 11;

      test.push({
        date: new Date(2023, 1, i),
        available: random >= 5 ? true : false
      })

      console.log(test)
    }
  }

  return (
    <div className="calendar">
      <LocalizationProvider dateAdapter={AdapterDayjs}>
        <StaticDatePicker
          displayStaticWrapperAs="desktop"
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
        />
      </LocalizationProvider>
    </div>
  )
}

export default Calendar;