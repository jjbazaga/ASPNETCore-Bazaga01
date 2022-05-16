using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Site01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            
            /*Exemplos
            * www.site.com.br/noticia/visualizar/
            * {dominio}comprado no registro.br/{controler}classe/Metodo{Action}/{Id?}opcional ex: Acidentes de veículos em Brasilia ou numero
            * www.site.com.br/cliente/lista (página de lista de clientes)
            * www.site.com.br/cliente/deletar/30 (deletar cliente de número 30)
            * www.site.com.br/cliente/visualizar/30 (visualizar cliente de número 30)
            * {dominio}/{Controler/Home = Index}/{Action = Inde}/{Id?}
            */

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();


            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            */
        }
    }
}