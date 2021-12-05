using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ELECTION.Models
{
    public partial class Vote
    {
        public Vote()
        {
          
        }

        public int VoteId { get; set; }
        
        public int ElecteurId { get; set; }
        public virtual Electeur Electeur { get; set; }
     
    }
}
