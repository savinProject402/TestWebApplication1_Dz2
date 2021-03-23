using AutoMapper;
using Smartphones.Domain.Contracs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApplication1.Models;

namespace TestWebApplication1.Controllers
{
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
        public ActionResult Index()
        {
            var smartphones = _smartphonesServices.GetAll();

            var smartVm = _mapper.Map<List<SmartphonesViewModel>>(smartphones);
            var data = new GetSmartphonesViewModel
            {
                Smartphones = smartVm
            };

            return View(data);
        }
    }
}