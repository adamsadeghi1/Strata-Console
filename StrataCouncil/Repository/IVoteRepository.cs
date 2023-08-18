using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrataCouncil.Repository
{
    internal interface IVoteRepository
    {
         int Save(Vote vote, int measureId);
         Vote FindById(int id);
         List<Vote> FindAll();
         Vote Delete(int id);
    }
}
