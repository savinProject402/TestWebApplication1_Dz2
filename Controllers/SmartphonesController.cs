using AutoMapper;
using Smartphones.Domain.Contracs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using TestWebApplication1.Models;

namespace TestWebApplication1.Controllers
{
    [RoutePrefix("Smartphones")]
    public class SmartphonesController : Controller
	{
        private readonly ISmartphonesServices _smartphonesServices;
		private readonly IMapper _mapper;

        public SmartphonesController(ISmartphonesServices smartphonesServices, IMapper mapper)
        {
            _smartphonesServices = smartphonesServices;
            _mapper = mapper;
        }

        //GET: Smartphones
        public ActionResult Index(PagingViewModel model)
        {
            var smartphones = _smartphonesServices.GetAll();

            if (model.Page.HasValue && model.PageSize.HasValue)
                smartphones = smartphones.Skip(model.PageSize.Value * (model.Page.Value - 1)).ToList();

            if (model.PageSize.HasValue)
                smartphones = smartphones.Take(model.PageSize.Value).ToList();

            //var identuty = User.Identity as ClaimsIdentity;
            //var userId = identuty.Claims.First(x=>x.Type==ClaimTypes.NameIdentifier).Value;

            var smartVm = _mapper.Map<List<SmartphonesViewModel>>(smartphones);
            var data = new GetSmartphonesViewModel
            {
                Smartphones = smartVm
            };

            return View(data);
        }
        [Route("Test/{id}")]
        public ActionResult GetById(int id)
        {
            var smartphones = _smartphonesServices.GetAll().First(x=>x.Id==id);

            var vm = _mapper.Map<SmartphonesViewModel>(smartphones);

            return View(vm);
        }
    }
}