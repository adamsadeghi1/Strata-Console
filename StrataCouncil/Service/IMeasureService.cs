using StrataCouncil.Models;
using StrataCouncil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrataCouncil.Service
{
    internal interface IMeasureService
    {
        int Save(Measure measure);
        Measure FindById(int id);
        List<Measure> FindAll();
    }
}
