﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace name_sorter
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string FourthName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {OtherName} {FourthName}".Trim();
        }
    }
}
