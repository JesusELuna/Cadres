﻿using Cadres.Data.Context;
using Cadres.Data.Repository.Implement;
using Cadres.Data.Repository.Interface;
using Ninject.Modules;

namespace Cadres.IoD.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            /* Context */
            CadresContext Context = new CadresContext();

            /* DAO */
            Bind<IVarillaRepository>().To<VarillaRepository>().WithConstructorArgument("dbContext", Context);
            Bind<ICompradorRepository>().To<CompradorRepository>().WithConstructorArgument("dbContext", Context);
            Bind<IMarcoRepository>().To<MarcoRepository>().WithConstructorArgument("dbContext", Context);
            Bind<IPedidoRepository>().To<PedidoRepository>().WithConstructorArgument("dbContext", Context);

            /* Services */
            //Bind<ICompradorService>().To<CompradorService>();
            //Bind<IVarillaService>().To<VarillaService>();
            //Bind<IMarcoService>().To<MarcoService>();
            //Bind<IPedidoService>().To<PedidoService>();
        }
    }
}