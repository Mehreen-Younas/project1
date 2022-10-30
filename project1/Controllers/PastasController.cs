using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project1.Models;
using project1.Services;
using System.Collections.Generic;

namespace Forkful.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PastasController : ControllerBase
    {
        JsonPastaFile PastaService { get; }
        public PastasController(JsonPastaFile PastaService)
        {
         this.PastaService = PastaService;
        }
        [HttpGet]
        public IEnumerable<Pasta> Get()
        {
           return PastaService.getPastaData();
        }
    }
}
