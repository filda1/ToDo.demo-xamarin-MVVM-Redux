using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_Simple_MVVM_Redux.Model
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Todo { get; set; }
        public bool Completed { get; set; }

    }
}
