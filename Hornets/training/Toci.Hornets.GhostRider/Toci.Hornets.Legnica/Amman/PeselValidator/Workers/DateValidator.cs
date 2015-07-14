﻿using Toci.Hornets.Legnica.Amman.PeselValidator.Workers.DateValidation;

namespace Toci.Hornets.Legnica.Amman.PeselValidator.Workers
{
    public class DateValidator
    {
        public static bool IsValid(int day, int month, int year)
        {
            return DayValidator.IsValid(day,month,year)&& MonthValidator.IsValid(month)&&
                   YearValidator.IsValid(year);
        }
    }
}