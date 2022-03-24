using API_PROJECT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDb;

        public ProductsController(ApplicationDbContext applicationDb) {
            this.applicationDb = applicationDb;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products = applicationDb.products.ToList();
           
                return Ok(products);
            
        }
        [HttpPost]
        public IActionResult post(Products products)
        {
            applicationDb.products.Add(products);
            applicationDb.SaveChanges();
            return Ok(new { Ok = true, message = "Product Created Successfully............" });
        }

    }
}
