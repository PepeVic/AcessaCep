using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AcessarCep.DTO;
using AcessarCep.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AcessarCep.Controllers
{
    [Route("")]
    public class CepController : Controller
    {
        private readonly ICepService _cepService;

        public CepController(ICepService cepService)
        {
            _cepService = cepService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("search-cep")]
        public async Task<IActionResult> SearchCep(string cep)
        {
            Address address = null;
            ViewBag.Error = false;
            try
            {
                address = await _cepService.GetAddress(cep);
            }
            catch
            {
                ViewBag.Error = true;
            }
            return View("SearchCep", address);
        }



    }
}
