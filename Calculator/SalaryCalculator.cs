﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursinYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursinYear;

        public decimal GetHourlyWage(decimal annualSalary) => annualSalary / HoursinYear;
    }
}
