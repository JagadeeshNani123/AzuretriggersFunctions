using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzuretriggersFunctions.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
