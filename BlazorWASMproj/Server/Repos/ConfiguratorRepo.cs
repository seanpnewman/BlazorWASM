using BlazorWASMproj.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASMproj.Server.Repos
{
    public class ConfiguratorRepo
    {
        public List<Configurator> GetConfigurators()
        {

            Configurator Icfs = new Configurator
            {
                Name = "My test",
                ID = 99,
                Description = "Desc"
            };

            List<Configurator> Icf = new List<Configurator>
            {
                Icfs
            };

            return Icf;
        }
    }
}