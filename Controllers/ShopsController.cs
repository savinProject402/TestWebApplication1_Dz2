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
    [RoutePrefix("Shops")]
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

        public ActionResult Index(PagingViewModel model)
        {
            var shops = _shopServices.GetAll();

            if (model.Page.HasValue && model.PageSize.HasValue)
                shops = shops.Skip(model.PageSize.Value * (model.Page.Value - 1)).ToList();

            if (model.PageSize.HasValue)
                shops = shops.Take(model.PageSize.Value).ToList();

            //var identuty = User.Identity as ClaimsIdentity;
            //var userId = identuty.Claims.First(x=>x.Type==ClaimTypes.NameIdentifier).Value;

            var shopVm = _mapper.Map<List<ShopViewModel>>(shops);
            var data = new GetShopsViewModel
            {
                Shops = shopVm
            };

            return View(data);
        }

        [Route("{id}")]
        public ActionResult GetById(int id)
        {
            var shop = _shopServices.GetAll().First(x => x.Id == id);

            var vm = _mapper.Map<ShopViewModel>(shop);

            return View(vm);
        }

        
        [Route("Update{Id}/")]
        
        public ActionResult Update (int Id)
        {
            var shop = _shopServices.GetById(Id);
            var shopPostModel = _mapper.Map<ShopPostModel>(shop);
            return View(shopPostModel);

        }
        [HttpPost]
        public ActionResult Create(ShopPostModel model)
        {
            var createModel = _mapper.Map<ShopModel>(model);
            _shopServices.Create(createModel);

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult Update(ShopPostModel model)
        {
            var editModel = _mapper.Map<ShopModel>(model);
            _shopServices.Update(editModel);

            return new EmptyResult();

        }
    }
}
