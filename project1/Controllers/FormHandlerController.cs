using Microsoft.AspNetCore.Mvc;
using project1.Models;
using project1.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Forkful.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsonPastaFile PastaService;
       public FormHandlerController(JsonPastaFile pastaService)
        {
          this.PastaService = pastaService;
        }

        [HttpGet]

        public string Get(int id, string name, string image)
        {
            Pasta obj = new Pasta();
            obj.pasta_id = id;
            obj.pasta_name = name;
            obj.pasta_image = image;

            IEnumerable<Pasta> pastasData = PastaService.getPastaData();
            List<Pasta> listofPastas= pastasData.ToList();
            listofPastas.Add(obj);

           return JsonSerializer.Serialize<List<Pasta>>(listofPastas);
        }

    }
}
