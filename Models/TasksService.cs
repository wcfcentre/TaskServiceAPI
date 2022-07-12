using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.Models
{
    public class TasksService
    {
        public TasksService(int id, string Description, string Priority, string Status, string Custid)
        {
            TaskId = id;
            TaskDescription = Description;
            TaskPriority = Priority;
            //TaskStatus = Status;
            CustomerId = Custid;
            _TaskStatus = new List<string>
                            {
                                "STARTED",
                                "IN_PROGRESS",
                                "COMPLETED",
                                "FAILED"
                            };
        }

        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public string TaskPriority { get; set; }
        //Task Status[STARTED, IN_PROGRESS, COMPLETED, FAILED],

        //public string TaskStatus { get; set; }
        public List<String> _TaskStatus { get; set; }

        public List<string> TaskStatus2
        {
            get { return _TaskStatus; }
            set { _TaskStatus = value; }
        }

        [Required]
        public string TasksAsString
        {
            get { return String.Join(',', _TaskStatus); }
            set { _TaskStatus = value.Split(',').ToList(); }
        }
        public string CustomerId { get; set; }
    }
}
