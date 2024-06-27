using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    //ESTA CLASE NOS VA PERMITIR AGRUPAR NUESTRAS INYECCIONES O MATRICULAS 
    // DE NUESTROS SERVICIOS PROPIOS O ESTERNOS
    public static class ServicesExtensions
    {
        public static void AddAplicationsLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());//EJECUTA EL MAPEO AUTOMATICO DE LOS OBJETOS
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
