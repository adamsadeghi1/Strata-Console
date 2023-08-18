using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using StrataCouncil.Service;
using StrataCouncil.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Mvc;
using System.Web.Routing;
using Unity;

namespace StrataCouncil.Controllers
{
    public class MeasureController : Controller
    {

        private IMeasureService MeasureService;
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            var container = HttpContext.Application["UnityContainer"] as IUnityContainer;
            MeasureService = container.Resolve<IMeasureService>();
        }

        public MeasureController()
        {
            
        }
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowMeasure()
        {
            List<Measure> measureslst = MeasureService.FindAll();
            var measures = new MeasureModelContext(measureslst);
            return View(measures);
        }


       
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var model = new Measure();
                UpdateModel<Measure>(model);
                MeasureService.Save(model);

                return RedirectToAction("ShowMeasure");
            }
            catch
            {
                return View();
            }
        }

  
        public ActionResult Edit(int id)
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

  
        public ActionResult Delete(int id)
        {
            return View();
        }

   
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
