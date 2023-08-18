using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StrataCouncil.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        [Required(ErrorMessage = "Voter name is required.")]
        public string VoterName { get; set; }

        [Display(Name = "Check For yes")]
        public bool VotedYes { get; set; }

        public virtual Measure Measure  { get; set; }
    }
}