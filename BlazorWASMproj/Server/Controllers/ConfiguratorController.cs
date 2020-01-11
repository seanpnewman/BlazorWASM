using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorWASMproj.Shared.Models;
using BlazorWASMproj.Server.Repos;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace BlazorWASMproj.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class ConfiguratorController : ControllerBase
    {
        [HttpGet]
        //[Route("GetAll")]
        public List<Configurator> Get()
        {
            ConfiguratorRepo repo = new ConfiguratorRepo();

            return repo.GetConfigurators();
        }
    }
}