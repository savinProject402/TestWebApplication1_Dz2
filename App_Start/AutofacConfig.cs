using Autofac;
using Autofac.Integration.Mvc;
using Smartphones.Data.Contract;
using Smartphones.Data.Repositories;
using Smartphones.Domain.Contracs;
using Smartphones.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApplication1.App_Start
{
	public class AutofacConfig
	{
		public static void ConfigureConteiner()
		{
			var builder = new ContainerBuilder();

			builder.RegisterControllers(typeof(MvcApplication).Assembly);
			builder.RegisterType<SmartphonesServices>().As<ISmartphonesServices>();
			builder.RegisterType<SmartphonesRepository>().As<ISmartphonesRepository>();
			builder.RegisterType<ShopServices>().As<IShopServices>();
			builder.RegisterType<ShopsRepository>().As<IShopsRepository>();
			builder.RegisterModule<AutoMapperModule>();
			var conteiner = builder.Build();

			DependencyResolver.SetResolver(new AutofacDependencyResolver(conteiner));
		}
	}
}