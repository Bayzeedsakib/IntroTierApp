using BLL.DTOs;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View(new DepartmentDTO());
        }

        [HttpPost]
        public IActionResult Create(DepartmentDTO d)
        {
            if (ModelState.IsValid)
            {
                var res = service.Create(d);

                if(res == true)
                {
                    return RedirectToAction("Get");
                }
                else
                {
                    TempData["Msg"] = "Error Occured";
                }
            }
            return View(d);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var data = service.GetById(id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Update(DepartmentDTO d)
        {
            if (ModelState.IsValid)
            {
                var res = service.Update(d);
                if(res == true)
                {
                    return RedirectToAction("Get");
                }
                else
                {
                    TempData["Msg"] = "Error Occured";
                }
            }

            return View(d);
        }

    }
}
