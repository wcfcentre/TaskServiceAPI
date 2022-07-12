using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaskService.Models
{
    public class TaskDBContext: DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options)
            : base(options)
        {
        }

        public DbSet<TasksService> TaskServices { get; set; }

    }
}
