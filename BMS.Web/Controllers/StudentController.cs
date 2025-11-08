using BMS.Application.Interfaces;
using BMS.Application.Services;
using BMS.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _service.GetAllAsync();
            return View(students);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var student = await _service.GetByIdAsync(id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (!ModelState.IsValid) return BadRequest(student);

            await _service.UpdateAsync(student);
            return RedirectToAction("Index");
        }


    }
}
