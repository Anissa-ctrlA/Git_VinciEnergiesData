﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VinciEnergiesData.Controllers
{
    [Authorize]
    public class FacturationFTTSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}