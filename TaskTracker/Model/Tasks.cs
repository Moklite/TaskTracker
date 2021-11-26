using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string ToDo { get; set; }
        public string Completed { get; set; }
        public DateTime DateCreated { get; set; }
        public  DateTime? DateUpated { get; set; }

    }
}
