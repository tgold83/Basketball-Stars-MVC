using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BasketballStars.Models;

namespace BasketballStars.Controllers
{
  public class PositionsController : Controller
  {
    public IActionResult Index()
    {
      var allPositions = Position.GetPositions();
      return View(allPositions);
    }
  }
}