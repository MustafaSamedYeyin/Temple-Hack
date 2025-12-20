using Microsoft.AspNetCore.Mvc;

namespace Hack.Ui.Areas.Job.Controllers;

public class JobController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
