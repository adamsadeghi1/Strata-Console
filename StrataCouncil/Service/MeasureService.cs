using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using StrataCouncil.Repository;
using System.Collections.Generic;
using System.Linq;


namespace StrataCouncil.Service
{
    public class MeasureService : IMeasureService   
    {
        private MeasureRepository measureRepository;
        public MeasureService(MeasureRepository measureRepository) {
            this.measureRepository = measureRepository;    
        }

        public int Save(Measure measure)
        {
            
            return measureRepository.Save(measure);
        }

        public Measure FindById(int id)
        {
            return measureRepository.FindById(id);
        }

        public List<Measure> FindAll()
        {
            return measureRepository.FindAll();
        }



    }
}