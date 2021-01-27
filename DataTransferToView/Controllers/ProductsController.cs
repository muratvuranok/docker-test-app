using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferToView.Models;

namespace DataTransferToView.Controllers
{
    public class ProductsController : Controller
    { 
        // View üzerinden Model'e data gönderme
        public IActionResult Index()
        {
            var products = Product.ProductList.Take(10);
            return View(model: products);
        } 
         
    }
}
