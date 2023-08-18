using StrataCouncil.Repository;
using StrataCouncil.Service;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace StrataCouncil
{
    public class MvcApplication : System.Web.HttpApplication
    {

        private IUnityContainer container;
        private IVoteService voteService;
        private IVoteRepository voteRepository;
        private IMeasureRepository measureRepository;
        private IMeasureService measureService;

        protected void Application_Start()
        {
            container = new UnityContainer();
            container.RegisterType<IVoteService, VoteService>();
            container.RegisterType<IVoteRepository, VoteRepository>();
            container.RegisterType<IMeasureRepository, MeasureRepository>();
            container.RegisterType<IMeasureService, MeasureService>();

            Application["UnityContainer"] = container;

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
