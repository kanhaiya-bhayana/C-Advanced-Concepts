﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationAPI
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }
    }
}
