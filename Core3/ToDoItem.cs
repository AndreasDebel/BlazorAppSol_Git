using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Model
{
    public class ToDoItem
    {
        public string Title { get; set; } = "";
        public bool IsDone { get; set; }

        public int Id { get; set; }
    }
}

