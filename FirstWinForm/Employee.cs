﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWinForm
{
    internal class Employee
    {
        public string ChineseName { get; set; }
        public string EnglishName { get; set; }
        public string EMPLOYECD { get; set; }
        public decimal Birthday { get; set; }
        // a string birthday to format like yyyy/MM/dd
        public string BirthdayString
        {
            get
            {
                return Birthday.ToString("yyyy/MM/dd");
            }
        }
    }
}
