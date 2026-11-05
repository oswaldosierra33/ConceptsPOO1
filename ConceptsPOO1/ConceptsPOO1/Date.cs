using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace ConceptsPOO1
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
                _year = year;
                _month = CheckMonth(month);
                _day = CheckDay(year, month, day);
        }
        // para establecer si el dia es valido, si es 29 de febrero y el año es bisiesto.
        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && DateTime.IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Dia Invalido");
        }
        //para establecer años viciestos.
        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
                       
            throw new MonthException("Mes Invalido");
           
        }

        public override string ToString()
        {
            //interpolación de string
            return $"{_year}/{_month:00}/{_day:00}";
        }

    }
        
}

