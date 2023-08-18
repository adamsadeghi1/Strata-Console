using StrataCouncil.Dbcontext;
using StrataCouncil.Models;
using StrataCouncil.Service;
using StrataCouncil.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrataCouncil.Controllers
{
    public class MeasureController : Controller
    {

        private MeasureService MeasureService;

        public MeasureController()
        {
            MeasureService = new MeasureService();
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
