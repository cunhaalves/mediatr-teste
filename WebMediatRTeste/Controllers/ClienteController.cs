using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebMediatRTeste.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}