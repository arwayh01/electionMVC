using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ELECTION.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ELECTIONUser class
    public class ELECTIONUser : IdentityUser
    {
        public string NomAdmin { get; set; }
        public string PrenomAdmin { get; set; }
        public string CinAdmin { get; set; }
        public string MotDePasse { get; set; }


    }
}
