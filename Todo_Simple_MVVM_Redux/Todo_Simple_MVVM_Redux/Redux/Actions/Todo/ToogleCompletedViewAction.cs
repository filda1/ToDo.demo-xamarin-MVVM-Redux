using Redux;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_Simple_MVVM_Redux.Redux.Actions.Todo
{
    public class ToogleCompletedViewAction:IAction { }

    public class NewTodoAction : IAction
    {
        public string Todo { get; }

        public NewTodoAction(string todo)
        {
            Todo = todo;
        }
    }

    public class CompleteTodoAction : IAction
    {
        public int Id { get; }

        public CompleteTodoAction(int todoId)
        {
            Id = todoId;
        }
       
    }

}
