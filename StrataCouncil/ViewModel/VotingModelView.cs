using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrataCouncil.ViewModel
{
    public class VotingModelView
    {
        public Measure Measure { get; set; }
        public Vote Vote { get; set; }
    }
}