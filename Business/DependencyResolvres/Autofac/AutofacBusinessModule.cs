using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Conrete;
using DataAccess.Conrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvres.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICustomerDal>().SingleInstance();
        }
    }
}
