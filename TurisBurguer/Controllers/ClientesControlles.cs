using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TurisBurguer.Models;

namespace TurisBurguer.Controllers;

public class ClientesController : Controller
{
    private ApplicationDbContext _context;

    //CONSTRUCTOR
    public ClientesController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }


}