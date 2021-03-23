using AutoMapper;
using Smartphones.Domain.Contracs;
using Smartphones.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApplication1.Models;

namespace TestWebApplication1.Controllers
{
    //[RoutePrefix("Shops")]
    public class ShopsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShopServices _shopServices;

        public ShopsController(IShopServices shopServices, IMapper mapper)
        {
            _shopServices = shopServices;
            _mapper = mapper;
        }
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(ShopPostModel model)
        {
            var createModel = _mapper.Map<ShopModel>(model);
            _shopServices.Create(createModel);

            return new EmptyResult();
        }

        [Route("{id}")]
        public ActionResult GetById(int id)
        {
            var shop = _shopServices.GetAll().First(x => x.Id == id);

            var vm = _mapper.Map<ShopViewModel>(shop);

            return View(vm);
        }

    }
}
