using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project1.Models;
using project1.Services;
using System.Collections.Generic;

namespace Forkful.Pages
{
    public class PastaItemsModel : PageModel
    {
        JsonPastaFile PastaService;
       public IEnumerable<Pasta> Pastas;
        public PastaItemsModel(JsonPastaFile pastaService)
        {
          this.PastaService = pastaService;
        }

        public void OnGet()
        {
            Pastas = PastaService.getPastaData();
        }
    }
}
