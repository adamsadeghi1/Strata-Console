using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrataCouncil.Repository
{
    internal interface IMeasureRepository
    {
         int Save(Measure measure);
         Measure FindById(int id);
         List<Measure> FindAll();
    }
}
