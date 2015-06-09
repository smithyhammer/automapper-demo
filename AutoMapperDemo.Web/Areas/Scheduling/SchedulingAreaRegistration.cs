using System.Web.Mvc;

namespace AutoMapperDemo.Web.Areas.Scheduling
{
    public class SchedulingAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Scheduling"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Scheduling",
                "Scheduling/{controller}/{action}/{id}",
                new {action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}