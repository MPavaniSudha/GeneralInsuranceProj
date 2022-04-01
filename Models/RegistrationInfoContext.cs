using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralInsuranceProject.Models
{
    public class RegistrationInfoContext:DbContext
    {
        public RegistrationInfoContext() : base("name=Customers")
        {

        }
        public DbSet<RegistrationInfo> customers { get; set; }
    }
}