using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2526_2221050318_BaiThi.Models;

namespace _2526_2221050318_BaiThi.Controllers;

public class NhanVienController : Controller
{
    [HttpPost]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }
    
}