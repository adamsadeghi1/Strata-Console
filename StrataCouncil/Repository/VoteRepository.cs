using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrataCouncil.Repository
{
    public class VoteRepository : IVoteRepository
    {
        private PoolContext cxdb;
        public VoteRepository(PoolContext cxdb) {
            this.cxdb = cxdb;
        }
        public int Save(Vote vote, int measureId)
        {
            var measure = FindMeasureById(measureId);
            vote.Measure = measure;
            cxdb.Votes.Add(vote);
            return cxdb.SaveChanges();
        }

        private Measure FindMeasureById(int id)
        {
            return cxdb.Measures.Where(x => x.Id == id).Single(); ;
        }


        public Vote FindById(int id)
        {
            return cxdb.Votes.Where(x => x.VoteId == id).Single(); ;
        }

        public List<Vote> FindAll()
        {
            return cxdb.Votes.ToList();
        }

        public Vote Delete(int id)
        {
            var vote = FindById(id);
            cxdb.Votes.Remove(vote);
            cxdb.SaveChanges();
            return vote;
        }
    }
}