using Autofac;
using AutoMapper;
using Smartphones.Data.Models;
using Smartphones.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWebApplication1.Models;

namespace TestWebApplication1.App_Start
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg => {

                cfg.CreateMap<SmartphonesModel, SmartphonesViewModel>(MemberList.Destination);
                cfg.CreateMap<Smartphon,SmartphonesModel>(MemberList.Destination);
                cfg.CreateMap<ShopPostModel, ShopModel>(MemberList.Source);
                cfg.CreateMap<ShopModel, Shop>(MemberList.Source);
            }));
            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
                .As<IMapper>()
                .InstancePerLifetimeScope();
        }
        
    }
}