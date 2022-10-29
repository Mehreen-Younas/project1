using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using project1.Models;
using project1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Pages
{
    public class IndexModel : PageModel
    {
      public IEnumerable<Pasta> Pastas { get; private set; }
        public JsonPastaFile PastaService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonPastaFile pastaService)
        {
            _logger = logger;
            PastaService = pastaService;
        }

        public void OnGet()
        {
            Pastas = PastaService.getPastaData();



        }
    }
}
