﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ElectroCardsWebApplication.Models
{
    public class PatientContext : DbContext
    {
       
        public DbSet<Patient> Patients { get; set; }
        
    }
}