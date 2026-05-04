using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace MVCAppLayer.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentService service;
        public DepartmentController(DepartmentService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = service.GetById();
            return View(data);
        }

        public IActionResult GetById(int id)
        {
            var data = service.GetById(id);
            return View(data);
        }
    }
}
