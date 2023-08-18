using StrataCouncil.Models;
using StrataCouncil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrataCouncil.Service
{
    internal interface IVoteService
    {
        int Save(Vote vote, int measureId);
        Vote FindById(int id);
        List<Vote> FindAll();
        Vote Delete(int id);
    }
}
