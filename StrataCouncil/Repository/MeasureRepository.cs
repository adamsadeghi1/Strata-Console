using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrataCouncil.Repository
{
    public class MeasureRepository : IMeasureRepository
    {
        private PoolContext cxdb;
        public MeasureRepository(PoolContext cxdb) {
            this.cxdb = cxdb;
        }
        public int Save(Measure measure)
        {
            cxdb.Measures.Add(measure);
            return cxdb.SaveChanges();
        }

        public Measure FindById(int id)
        {
            return cxdb.Measures.Where(x => x.Id == id).Single(); ;
        }

        public List<Measure> FindAll()
        {
            return cxdb.Measures.ToList();
        }
    }
}