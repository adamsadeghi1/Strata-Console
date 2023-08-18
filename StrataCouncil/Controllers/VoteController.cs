using Newtonsoft.Json.Linq;
using StrataCouncil.Models;
using StrataCouncil.Service;
using StrataCouncil.ViewModel;
using System.Web.Mvc;

namespace StrataCouncil.Controllers
{
    public class VoteController : Controller
    {
        private MeasureService measureService;
        private VoteService voteService;

        public VoteController()
        {
            measureService = new MeasureService();
            voteService = new VoteService();
        }

        public ActionResult Index()
        {
            var measureslst = measureService.FindAll();
            var measures = new MeasureModelContext(measureslst);
            return View(measures);
        }

        public ActionResult VotedList() 
        {
            var votelist = voteService.FindAll();
            var Votes = new VotedListModelContext(votelist);
            return View(Votes);
        }
      

        public ActionResult Voting(int? id)
        {
            if (id == null){
                Session["measureId"] = null;
                return RedirectToAction("Index");
            }
            else{
                Session["measureId"] = id; 
            }

            var voting = new VotingModelView();
            voting.Measure =  measureService.FindById((int)id);


            return View(voting);
        }


       
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var model = new VotingModelView();
                UpdateModel<VotingModelView>(model);
                int measureId;

                if(Session["measureId"] !=  null)
                {
                    measureId = (int)Session["measureId"];
                }
                else
                {
                    return RedirectToAction("Index");
                }
                voteService.Save(model.Vote, measureId);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
    }
}
