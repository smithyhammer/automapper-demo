using System.Web.Mvc;
using AutoMapper;
using AutoMapperDemo.Business.Models;
using AutoMapperDemo.Interfaces;
using AutoMapperDemo.Utility;
using AutoMapperDemo.Web.Areas.Scheduling.Models;

namespace AutoMapperDemo.Web.Areas.Scheduling.Controllers
{
    public class ProgramController : Controller
    {
        private readonly IConvert _convert;

        public ProgramController(IConvert convert)
        {
            _convert = convert;
        }

        // GET: Scheduling/Program
        public ActionResult Index()
        {
            var programModel = new ProgramModel
                               {
                                   Id = 2,
                                   ProgramName = "Project Jacuuzi",
                                   Description = "Top Secret"
                               };
            var partModel = new PartsModel
                            {
                                Id = 12345,
                                IsAvailable = true,
                                PartName = "My Jacuuzi Scrubber"
                            };

            var myModel = Convert.MapModel<ProgramModel, ProgramViewModel>(programModel);
            var myNewModel = _convert.MapModel<ProgramModel, ProgramViewModel>(programModel);

            Mapper.CreateMap<ProgramModel, ProgramViewModel>();
            var model = Mapper.Map<ProgramViewModel>(programModel);

            return View(myNewModel);
        }
    }
}