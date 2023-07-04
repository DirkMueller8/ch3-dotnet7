using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ch3_dotnet7.Models;

namespace ch3_dotnet7.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public ViewResult RsvpForm()
    {
        return View();
    }
}