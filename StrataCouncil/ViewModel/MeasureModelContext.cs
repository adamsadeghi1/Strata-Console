using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrataCouncil.ViewModel
{
    public class MeasureModelContext
    {
        public List<Measure>  Measures { get; set; }

        public MeasureModelContext(List<Measure> measures)
        {
            Measures = measures;
        }

    }
}