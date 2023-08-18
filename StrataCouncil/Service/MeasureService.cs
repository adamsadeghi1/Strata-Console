using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using System.Collections.Generic;
using System.Linq;


namespace StrataCouncil.Service
{
    public class MeasureService
    {
        private PoolContext cxdb; 
        public MeasureService() {
            this.cxdb = new PoolContext();
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