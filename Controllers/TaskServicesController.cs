using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskService.Models;

namespace TaskService.Controllers
{
    public class TaskServicesController : ControllerBase
    {
        
        private readonly TaskDBContext _context;

        public TaskServicesController(TaskDBContext context)
        {
            _context = context;
        }

        // GET: TaskServicesController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: TaskServicesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TaskServicesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskServicesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskServicesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaskServicesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskServicesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TaskServicesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
