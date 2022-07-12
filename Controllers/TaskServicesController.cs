using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // GET: api/TaskService
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TasksService>>> GetTasksService()
        {
            return await _context.TaskServices.ToListAsync();
        }

        // GET: api/TaskService/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TasksService>> GetTaskService(int id)
        {
            var tasks = await _context.TaskServices.FindAsync(id);

            if (tasks == null)
            {
                return NotFound();
            }

            return tasks;
        }

        // PUT: api/TaskService/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskService(int id, TasksService tasks)
        {
            if (id != tasks.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(tasks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TasksServiceExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TasksService>> PostTasksService(TasksService tasks)
        {
            _context.TaskServices.Add(tasks);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskService", new { id = tasks.TaskId }, tasks);
        }

        public async Task<IActionResult> DeletePet(int id)
        {
            var pet = await _context.TaskServices.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            _context.TaskServices.Remove(pet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TasksServiceExist(int id)
        {
            //throw new NotImplementedException();
            return _context.TaskServices.Any(e => e.TaskId == id);
        }


    }
}
