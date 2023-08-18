using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrataCouncil.ViewModel
{
    public class VotedListModelContext
    {
        public List<Vote> Votes { get; set; }

        public VotedListModelContext(List<Vote> votes)
        {
            Votes = votes;
        }
    }
}