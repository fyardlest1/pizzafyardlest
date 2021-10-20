using Microsoft.AspNetCore.Mvc;
using pizza_fyard.Data;
using pizza_fyard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_fyard.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        // Retrieve the Datacontext in a constructor
        // to get access to the list of pizzas in our database
        DataContext dataContext;
        public ApiController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            // Using the dataContext to retrive the pizzas in a Json format
            var pizzas = dataContext.Pizzas.ToList();
            return Json(pizzas);
        }
    }
}
