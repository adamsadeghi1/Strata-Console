using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using StrataCouncil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrataCouncil.Service
{
    public class VoteService : IVoteService
    {
        private VoteRepository voteRepository;
        public VoteService(VoteRepository voteRepository)
        {
            this.voteRepository = voteRepository;
        }

        public int Save(Vote vote, int measureId)
        {
           return voteRepository.Save(vote, measureId);
        }

        public Vote FindById(int id)
        {
            return voteRepository.FindById(id);
        }

        public List<Vote> FindAll()
        {
            return voteRepository.FindAll();
        }

        public Vote Delete(int id) { 
            return voteRepository.Delete(id);
        }

    }
}