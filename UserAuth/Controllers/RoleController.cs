using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserAuth.core;

namespace UserAuth.Controllers
{
    public class RoleController : Controller
    {
        [Authorize(Policy = "EmployeeOnly")]
        public IActionResult Index()
        {
            return View();
        }
        //[Authorize(Policy = "RequireManager")]
        [Authorize(Roles = $"{Constants.Roles.Administrator}, {Constants.Roles.Manager}")]

        public IActionResult Manager()
        {
            return View();
        }

        //[Authorize(Policy = "RequireAdmin")]
        //[Authorize(Roles = "Administrator, Manager")]
        [Authorize(Roles =$"{Constants.Roles.Administrator}, {Constants.Roles.Manager}")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
