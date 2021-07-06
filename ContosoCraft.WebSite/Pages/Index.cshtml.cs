using ContosoCraft.WebSite.Models;
using ContosoCraft.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCraft.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, 
            JsonFileProductService productServices)
        {
            _logger = logger;
            ProductService = productServices;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
