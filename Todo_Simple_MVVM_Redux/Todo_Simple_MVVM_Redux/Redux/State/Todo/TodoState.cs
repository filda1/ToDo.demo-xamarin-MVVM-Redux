using System;
using System.Collections.Generic;
using System.Text;
using Todo_Simple_MVVM_Redux.Model;

namespace Todo_Simple_MVVM_Redux.Redux.State.Todo
{
    public class TodoState
    {
        public bool ShowCompleted { get; set; }
        public string Text { get; set; }

        public List<TodoItem> Todos { get; set; } = new List<TodoItem>();


        public static TodoState InitialState => new TodoState()
        {
           
            Text = "",
            ShowCompleted = true,

            Todos = new List<TodoItem>()
            {
                new TodoItem()
                {
                    Id=1,
                    Todo = "Todo 1",
                    //Completed = true
                    
                },
                new TodoItem()
                {
                    Id=2,
                    Todo = "Todo 2",
                       //Completed = true

                },
                new TodoItem()
                {
                    Id=3,
                    Todo = "Todo 3",
                    //Completed = false
                     //Completed = true
                }
            }
        };
    }
}
