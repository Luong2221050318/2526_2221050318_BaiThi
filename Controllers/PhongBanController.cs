using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2526_2221050318_BaiThi.Models;

namespace _2526_2221050318_BaiThi.Controllers;

public class PhongBanController : Controller
{
    [HttpPost]
    public IActionResult Index()
    {
        return View();
    }
   
}