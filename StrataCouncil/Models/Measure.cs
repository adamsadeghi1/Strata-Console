using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StrataCouncil.Models
{
    public class Measure
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public virtual ICollection<Vote> Votes { get; set; } = new List<Vote>();
        public MeasureStatus Status { get; set; }
        public int MinVotesRequired { get; set; }
        public double MinPercentageRequired { get; set; }


        public enum MeasureStatus
        {
            Open,
            Passed,
            Failed
        }
    }
}